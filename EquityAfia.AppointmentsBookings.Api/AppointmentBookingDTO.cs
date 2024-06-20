namespace EquityAfia.AppointmentsBookings.Api
{
    public class AppointmentBookingDTO
    {
        //public string AppointmentId { get; set; }
        public string BookFor { get; set; }
        public string Service { get; set; }
        public DateTime Date { get; set; }
        public string AppointmentType { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
