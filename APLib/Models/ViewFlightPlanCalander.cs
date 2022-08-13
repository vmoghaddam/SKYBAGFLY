﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APLib.Models
{
    public partial class ViewFlightPlanCalander
    {
        public int Id { get; set; }
        public int CalendarId { get; set; }
        public DateTime? Date { get; set; }
        public int? FlightPlanRegisterId { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public int? IsLocked { get; set; }
        public int? IsOpen { get; set; }
        public bool? IsApplied { get; set; }
        public DateTime? DateApplied { get; set; }
        public string Title { get; set; }
        public int? BaseId { get; set; }
        public string BaseName { get; set; }
        public string BaseIATA { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateActive { get; set; }
        public string Customer { get; set; }
        public int? Interval { get; set; }
        public string IntervalType { get; set; }
        public string Types { get; set; }
        public int? TotalFlights { get; set; }
        public int? VirtualRegisterId { get; set; }
        public string VirtualRegister { get; set; }
        public int? VirtualTypeId { get; set; }
        public decimal? RegisterAssignProgress { get; set; }
        public int IsApproved100 { get; set; }
        public int IsApproved50 { get; set; }
        public DateTime? DateApproved100 { get; set; }
        public DateTime? DateApproved50 { get; set; }
        public int IsApproved60 { get; set; }
        public DateTime? DateApproved60 { get; set; }
        public int IsApproved70 { get; set; }
        public DateTime? DateApproved70 { get; set; }
        public DateTime? DateApproved80 { get; set; }
        public int IsApproved80 { get; set; }
        public int IsApproved90 { get; set; }
        public DateTime? DateApproved90 { get; set; }
    }
}
