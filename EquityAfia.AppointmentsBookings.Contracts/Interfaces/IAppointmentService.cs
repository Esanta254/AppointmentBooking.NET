/*

using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Contracts.Interfaces
{
    public interface IAppointmentService
    {
        Task CreateAppointmentAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync();
        Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentInd); 
        Task UpdateAppointmentAsync(AppointmentBooking appointmentBooking); 
        Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync();
        Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync();
    }
}

*/
































using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Contracts.Interfaces
{
    public interface IAppointmentService
    {
        Task CreateAppointmentAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync();
        Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId);
        Task UpdateAppointmentAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync();
        Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync();
    }
}