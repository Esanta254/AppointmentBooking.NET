/*
using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Domain.Interfaces;
using EquityAfia.AppointmentsBookings.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace EquityAfia.AppointmentsBookings.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task AddAsync(AppointmentBooking appointmentBooking)
        {
            await _context.AppointmentBookings.AddAsync(appointmentBooking);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync()
        {
            return await _context.AppointmentBookings.ToListAsync();
        }
        public async Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId)
        {
            var appointment = await _context.AppointmentBookings.FindAsync(AppointmentId);
            return appointment ?? throw new KeyNotFoundException("Appointment Not Found");
        }
        public async Task UpdateAsync(AppointmentBooking appointmentBooking)
        {
            _context.AppointmentBookings.Update(appointmentBooking);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync()
        {
            return await _context.AppointmentBookings
                .Where(appointment => appointment.Status == "Approved")
                .ToListAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync()
        {
            return await _context.AppointmentBookings
                .Where(appointment => appointment.Status == "Pending")
                .ToListAsync();
        }
    }
}

*/



































using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Domain.Interfaces;
using EquityAfia.AppointmentsBookings.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;


namespace EquityAfia.AppointmentsBookings.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;
        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(AppointmentBooking appointmentBooking)
        {
            await _context.AppointmentBookings.AddAsync(appointmentBooking);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync()
        {
            return await _context.AppointmentBookings.ToListAsync();
        }
        public async Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId)
        {
            var appointment = await _context.AppointmentBookings.FindAsync(AppointmentId);
            return appointment ?? throw new KeyNotFoundException("Appointment not found");
        }
        public async Task UpdateAsync(AppointmentBooking appointmentBooking)
        {
            _context.AppointmentBookings.Update(appointmentBooking);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync()
        {
            return await _context.AppointmentBookings
                .Where(appointment => appointment.Status == "Approved")
                .ToListAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync()
        {
            return await _context.AppointmentBookings
                .Where(appointment => appointment.Status == "Pending ")
                .ToListAsync();
        }
    }
}


















