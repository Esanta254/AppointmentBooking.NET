namespace EquityAfia.AppointmentsBookings.Api
{
    public class AppointmentBookingDTO
    {
        public string BookFor { get; set; } = null!;
        public string Service { get; set; } = null!;
        public DateTime Date { get; set; }
        public string AppointmentType { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string IdNumber { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
    }
}
