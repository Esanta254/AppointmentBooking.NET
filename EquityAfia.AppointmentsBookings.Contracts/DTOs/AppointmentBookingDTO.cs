namespace EquityAfia.AppointmentsBookings.Api
{
    public class AppointmentBookingDTO
    {
        public string IdNumber { get; set; } = null!;
        public string BookFor { get; set; } = null!;
        public string Service { get; set; } = null!;
        public string AppointmentType { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string Residence { get; set; } = null!;
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; } = null!;
       
    }
}
