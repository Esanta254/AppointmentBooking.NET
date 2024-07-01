

using EquityAfia.AppointmentsBookings.Domain.Entities;
using EquityAfia.AppointmentsBookings.Domain.Interfaces;
using System.Threading.Tasks;

namespace EquityAfia.AppointmentsBookings.Application
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public Task CreateAppointment(AppointmentBooking appointmentBooking)
        {
            // Add any business logic or validation here if needed
            return _appointmentRepository.AddAsync(appointmentBooking);
        }

        public Task<IEnumerable<AppointmentBooking>> GetAllAppointments()
        {
            return _appointmentRepository.GetAllAppointments();
        }

        public Task<AppointmentBooking> GetAppointmentById(string id)
        {
            return _appointmentRepository.GetAppointmentById(id);
        }
    }
}

