

using Microsoft.AspNetCore.Mvc;
using EquityAfia.AppointmentsBookings.Application;
using EquityAfia.AppointmentsBookings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EquityAfia.AppointmentsBookings.Api.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly AppointmentService _appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }


        [HttpPost]
        [Route("BookAppointment")]
        public async Task<IActionResult> CreateAppointment([FromBody] AppointmentBookingDTO dto)
        {
            // Generate a unique appointment ID starting with 'A' followed by 6 digits
            var appointmentId = GenerateAppointmentId();

            var appointmentBooking = new AppointmentBooking
            {
                AppointmentId = appointmentId,
                BookFor = dto.BookFor,
                Service = dto.Service,
                Date = dto.Date,
                AppointmentType = dto.AppointmentType,
                FullName = dto.FullName,
                PhoneNumber = dto.PhoneNumber,
                IdNumber = dto.IdNumber,
                Gender = dto.Gender,
                Age = dto.Age
            };

            await _appointmentService.CreateAppointment(appointmentBooking);

            return Ok(new { Message = "Appointment created successfully" });
        }

        // Helper method to generate a unique appointment ID
        private string GenerateAppointmentId()
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000); // Generates a random number between 100000 and 999999
            return $"A{randomNumber}";
        }


        [HttpGet]
        [Route("GetAllAppointments")]
        public async Task<ActionResult<IEnumerable<AppointmentBooking>>> GetAllAppointments()
        {
            var appointments = await _appointmentService.GetAllAppointments();
            return Ok(appointments);
        }

        [HttpGet]
        [Route("GetOneAppointment")]
        public async Task<ActionResult<AppointmentBooking>> GetAppointmentById(string id)
        {
            var appointment = await _appointmentService.GetAppointmentById(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return Ok(appointment);
        }
    }
}

