﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APLib.Models
{
    public partial class ViewFlightCrewNewX
    {
        public int FDPId { get; set; }
        public int FDPItemId { get; set; }
        public int? CrewId { get; set; }
        public int? FlightId { get; set; }
        public bool? IsPositioning { get; set; }
        public int? PositionId { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string ScheduleName { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int SexId { get; set; }
        public string Sex { get; set; }
        public int? GroupOrder { get; set; }
        public int IsCockpit { get; set; }
        public long? Rank { get; set; }
        public long? RankPosition { get; set; }
        public DateTime? Pickup { get; set; }
        public DateTime? PickupLocal { get; set; }
    }
}