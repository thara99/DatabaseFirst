using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class Driverdetail
    {
        public int Regno { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
        public string Nic { get; set; }
        public string Contactno { get; set; }
        public string Address { get; set; }
        public int? Exp { get; set; }
    }
}
