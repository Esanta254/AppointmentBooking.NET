

using System.Threading.Tasks;
using EquityAfia.AppointmentsBookings.Contracts.DTOs;
using EquityAfia.AppointmentsBookings.Contracts.Interfaces;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace EquityAfia.AppointmentsBookings.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(EmailDto request)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailSettings:Username").Value));
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
                {
                    Text = request.Body
                };

                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                await smtp.ConnectAsync(
                    _config.GetSection("EmailSettings:Host").Value,
                    587,
                    SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(
                    _config.GetSection("EmailSettings:Username").Value,
                    _config.GetSection("EmailSettings:Password").Value);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new ApplicationException("An error occurred while sending the email.", ex);
            }
        }
    }
}

