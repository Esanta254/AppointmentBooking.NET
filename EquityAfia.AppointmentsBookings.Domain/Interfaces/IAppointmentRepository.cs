/*
using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        Task AddAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync();
        Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId);
        Task UpdateAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync();
        Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync();
    }
}

*/



















using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        Task AddAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync();
        Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId);
        Task UpdateAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync();
        Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync();   
    }
}















