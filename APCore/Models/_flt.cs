using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class _flt
    {
        public int ID { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? STD { get; set; }
        public string DEP { get; set; }
        public string ARR { get; set; }
    }
}
