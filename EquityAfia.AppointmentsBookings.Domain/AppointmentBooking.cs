using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquityAfia.AppointmentsBookings.Domain.Entities
{
    public class AppointmentBooking
    {
        public DateTime Date;

        public string AppointmentId { get; set; }
        public string BookFor { get; set; }
        public string Service { get; set; }
        public TimeSpan Time { get; set; }
        public string AppointmentType { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Status { get; set; } = "pending";
    }
}

