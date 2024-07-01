
using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Domain.Interfaces;
using EquityAfia.AppointmentsBookings.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EquityAfia.AppointmentsBookings.Infrastructure.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _dbContext;

        public AppointmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(AppointmentBooking appointmentBooking)
        {
            await _dbContext.AppointmentBookings.AddAsync(appointmentBooking);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AppointmentBooking>> GetAllAppointments()
        {
            return await _dbContext.AppointmentBookings.ToListAsync();
        }

        public async Task<AppointmentBooking> GetAppointmentById(string id)
        {
            return await _dbContext.AppointmentBookings
                                   .FirstOrDefaultAsync(a => a.AppointmentId == id);
        }
    }
}


