using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class Booking
    {
        public int? ReservationNo { get; set; }
        public string CustomerName { get; set; }
        public int? DriverId { get; set; }
        public DateTime? ReservationDate { get; set; }
        public string VehicleNumber { get; set; }
    }
}
