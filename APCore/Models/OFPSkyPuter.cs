﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class OFPSkyPuter
    {
        public int Id { get; set; }
        public int? FlightId { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? FlightDate { get; set; }
        public string OFP { get; set; }
        public string AIRLINE { get; set; }
    }
}
