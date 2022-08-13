﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APTraining.Models
{
    public partial class RV_Aircraft
    {
        public string Type { get; set; }
        public string Reg { get; set; }
        public string Seat { get; set; }
        public string Owner { get; set; }
        public string MaxCargoWeight { get; set; }
        public string Real { get; set; }
        public string GanttShowOrder { get; set; }
        public string Id { get; set; }
        public string FuelCapacity { get; set; }
        public string FuelUnit { get; set; }
    }
}
