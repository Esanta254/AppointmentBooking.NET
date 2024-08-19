using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquityAfia.AppointmentsBookings.Contracts.DTOs;

namespace EquityAfia.AppointmentsBookings.Contracts.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailDto request);
    }
}
