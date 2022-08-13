using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class _FMISTRN
    {
        public string Crew { get; set; }
        public string CourseName { get; set; }
        public string ScheduleName { get; set; }
        public string ACType { get; set; }
        public string CrewType { get; set; }
        public string StartDate { get; set; }
        public string Issue { get; set; }
        public string Recurrent { get; set; }
        public string Expire { get; set; }
        public string CourseType { get; set; }
        public int? RankLast { get; set; }
        public int? PersonId { get; set; }
    }
}
