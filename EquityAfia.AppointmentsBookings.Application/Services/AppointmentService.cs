
/*
using EquityAfia.AppointmentsBookings.Contracts.Interfaces;
using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Domain.Interfaces;


namespace EquityAfia.AppointmentsBookings.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task CreateAppointmentAsync(AppointmentBooking appointmentBooking)
        {
            await _appointmentRepository.AddAsync(appointmentBooking);
        }
        public async Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync()
        {
            return await _appointmentRepository.GetAllAppointmentsAsync();
        }
        public async Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId)
        {
            return await _appointmentRepository.GetAppointmentByIdAsync(AppointmentId);
        }
        public async Task UpdateAppointmentAsync(AppointmentBooking appointmentBooking)
        {
            await _appointmentRepository.UpdateAsync(appointmentBooking);
        }
        public async Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync()
        {
            return await _appointmentRepository.GetApprovedAppointmentsAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync()
        {
            return await _appointmentRepository.GetPendingAppointmentsAsync();
        }
    }
}

*/






































using EquityAfia.AppointmentsBookings.Contracts.Interfaces;
using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Domain.Interfaces;


namespace EquityAfia.AppointmentsBookings.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task CreateAppointmentAsync(AppointmentBooking appointmentBooking)
        {
            await _appointmentRepository.AddAsync(appointmentBooking);
        }
        public async Task<IEnumerable<AppointmentBooking>> GetAllAppointmentsAsync()
        {
            return await _appointmentRepository.GetAllAppointmentsAsync();
        }
        public async Task<AppointmentBooking> GetAppointmentByIdAsync(string AppointmentId)
        {
            return await _appointmentRepository.GetAppointmentByIdAsync(AppointmentId);
        }
        public async Task UpdateAppointmentAsync(AppointmentBooking appointmentBooking)
        {
            await _appointmentRepository.UpdateAsync(appointmentBooking);
        }
        public async Task<IEnumerable<AppointmentBooking>> GetApprovedAppointmentsAsync()
        {
            return await _appointmentRepository.GetApprovedAppointmentsAsync();
        }
        public async Task<IEnumerable<AppointmentBooking>> GetPendingAppointmentsAsync()
        {
            return await _appointmentRepository.GetPendingAppointmentsAsync();
        }
    }
}