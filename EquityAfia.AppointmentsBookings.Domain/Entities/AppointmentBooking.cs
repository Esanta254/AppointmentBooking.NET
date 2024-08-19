


using System.ComponentModel.DataAnnotations;

namespace EquityAfia.AppointmentsBookings.Domain.Entities
{
    public class AppointmentBooking
    {
        public String AppointmentId { get; set; } = null!;    
        public String BookFor { get; set; } = null!;
        public String Service { get; set; } = null!;
        public String AppointmentType { get; set; } = null!;
        public String Name { get; set; } = null!;
        public String PhoneNumber { get; set; } = null!;
        public String IdNumber { get; set; } = null!;
        public String Email { get; set; } = null!;
        public String Gender { get; set; } = null!;
        public int Age { get; set; }
        public String AppointmentStatus { get; set; } = "Pending";
        public String PaymentSatus { get; set; } = "Not Paid";
        public String Residence { get; set; } = null!;
        public DateTime AppointmentDate { get; set; }
        public String AppointmentTime { get; set; } = null!;
      
    }
}

















