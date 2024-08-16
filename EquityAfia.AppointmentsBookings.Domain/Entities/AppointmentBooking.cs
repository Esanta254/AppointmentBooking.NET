
/*
namespace EquityAfia.AppointmentsBookings.Domain.Entities
{
    public class AppointmentBooking
    {
      
        public string AppointmentId { get; set; } = null!;
        public string BookFor { get; set; } = null!;
        public string Service { get; set; } = null!;
        public DateTime Date { get; set; }
        public string AppointmentType { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string IdNumber { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Status { get; set; } = "pending";
    }
}

*/














using System.ComponentModel.DataAnnotations;

namespace EquityAfia.AppointmentsBookings.Domain.Entities
{
    public class AppointmentBooking
    {
        public String AppointmentId { get; set; } = null!;
        [Required]
        public String BookFor { get; set; }
        public String Service { get; set; } = null!;
        public DateTime Date { get; set; }
        public String AppointmentType { get; set; } = null!;
        public String FullName { get; set; } = null!;
        public String PhoneNumber { get; set; } = null!;
        public String IdNumber { get; set; } = null!;
        public String Gender { get; set; } = null!;
        public int Age { get; set; }
        public String Status { get; set; } = "Pending";
    }
}

















