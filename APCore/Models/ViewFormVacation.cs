using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFormVacation
    {
        public int Id { get; set; }
        public int Reason { get; set; }
        public string ReasonStr { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Remark { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string OperationRemak { get; set; }
        public string SchedulingRemark { get; set; }
        public DateTime? DateStatus { get; set; }
        public string Status { get; set; }
        public int? OperatorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string PID { get; set; }
        public string NID { get; set; }
        public string Mobile { get; set; }
        public string JobGroup { get; set; }
    }
}
