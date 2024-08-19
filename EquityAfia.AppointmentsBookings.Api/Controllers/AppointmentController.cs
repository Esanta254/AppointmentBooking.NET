

using EquityAfia.AppointmentsBookings.Contracts.DTOs;
using EquityAfia.AppointmentsBookings.Contracts.Interfaces;
using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;

namespace EquityAfia.AppointmentsBookings.Api.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IEmailService _emailService;

        public AppointmentController(IAppointmentService appointmentService, IEmailService emailService)
        {
            _appointmentService = appointmentService;
            _emailService = emailService;
        }

        //Book appointment Endpoint 
        [HttpPost]
        [Route("BookAppointment")]
        public async Task<IActionResult> CreateAppointment([FromBody] AppointmentBookingDTO dto)
        {
           
            try
            {
                if (dto == null)
                {
                    return BadRequest(new { Message = "DTO cannot be null." });
                }
                // Generate a unique appointment ID starting with 'A' followed by 6 digits
                var appointmentId = GenerateAppointmentId();

                var appointmentBooking = new AppointmentBooking
                {
                    AppointmentId = appointmentId,
                    IdNumber = dto.IdNumber,
                    BookFor = dto.BookFor,
                    Service = dto.Service,
                    AppointmentType = dto.AppointmentType,
                    Name = dto.Name,
                    PhoneNumber = dto.PhoneNumber,
                    Email = dto.Email,
                    Age = dto.Age,                
                    Gender = dto.Gender,
                    Residence = dto.Residence,
                    AppointmentDate = dto.AppointmentDate,
                    AppointmentTime = dto.AppointmentTime

                };

                await _appointmentService.CreateAppointmentAsync(appointmentBooking);
                var emailDto = new EmailDto
                {
                    To = dto.Email,
                    Subject = "Appointment Booking Confirmation",
                    Body = $"Your appointment has been successfully booked with ID: {appointmentId}."
                };
                await _emailService.SendEmailAsync(emailDto);

                return Ok(new { Message = "Appointment created successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Error booking appointment",
                    Error = ex.Message,
                });
            }
        }

        // Helper method to generate a unique appointment ID
        private static string GenerateAppointmentId()
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000); // Generates a random number between 100000 and 999999
            return $"A{randomNumber}";
        }

        //Getting all appointments Endpoint
        [HttpGet]
        [Route("GetAllAppointments")]
        public async Task<ActionResult<IEnumerable<AppointmentBooking>>> GetAllAppointments()
        {
            
           
            try
            {
                var appointments = await _appointmentService.GetAllAppointmentsAsync();
                if(appointments == null || !appointments.Any())
                {
                    return NotFound(new { Message = "No appointments found" });
                }
                return Ok(appointments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Error retrieving appointments",
                    Error = ex.Message,
                });
            }
        }

        //Getting one appointment Endpoint 
        [HttpGet]
        [Route("GetOneAppointment/{appointmentId}")]
        public async Task<ActionResult<AppointmentBooking>> GetAppointmentById(string appointmentId)
        {
           
           
            try
            {
                var appointment = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
                if (appointment == null)
                {
                    return NotFound(new { Message = "Appointment not found"});
                }
                return Ok(appointment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Internal server error",
                    Error = ex.Message,
                });
            }
        }

        //Approve appointment Endpoint
        [HttpPost]
        [Route("ApproveAppointment/{appointmentId}")]
        public async Task<IActionResult> ApproveAppointment(string appointmentId)
        {
            try
            {
                var appointment = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
                if (appointment == null)
                {
                    return NotFound(new { Message = "Appointment not found" });
                }

                if (appointment.AppointmentStatus == "approved")
                {
                    return BadRequest(new { Message = "Appointment is already approved" });
                }

                appointment.AppointmentStatus = "approved";
                await _appointmentService.UpdateAppointmentAsync(appointment);

                return Ok(new
                {
                    Message = "Appointment booking approved successfully",
                    Data = appointment
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Internal Server Error",
                    Error = ex.Message
                });
            }
        }

        //Getting approved appointments Endpoint 
        [HttpGet]
        [Route("GetApprovedAppointments")]
        public async Task<ActionResult<IEnumerable<AppointmentBooking>>> GetApprovedAppointments()
        {
            
            try
            {
                var approvedAppointments = await _appointmentService.GetApprovedAppointmentsAsync();
                if(approvedAppointments == null || !approvedAppointments.Any())
                {
                    return NotFound(new { Message = "No approved appointments found" });
                }
                return Ok(approvedAppointments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Internal server error",
                    Error = ex.Message,
                });
            }
        }

        //Getting pending appointments Endpoint 
        [HttpGet]
        [Route("GetPendingAppointments")]
        public async Task<ActionResult<IEnumerable<AppointmentBooking>>> GetPendingAppointments()
        {
     
            try
            {
                var pendingAppointments = await _appointmentService.GetPendingAppointmentsAsync();
                if(pendingAppointments == null || !pendingAppointments.Any())
                {
                    return NotFound(new { Message = "No pending appointments found" });
                }
                return Ok(pendingAppointments);
            }
            catch(Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Internal server error",
                    Error = ex.Message,
                });
            }
        }
    }
}

