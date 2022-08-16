using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FormRequest
    {
        public int Id { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateStatus { get; set; }
        public string Status { get; set; }
        public string RemarkUser { get; set; }
        public string RemarkOperation { get; set; }
        public int? TypeId { get; set; }
        public int? UserId { get; set; }
        public int? OperatorId { get; set; }
        public int? ReasonId { get; set; }
    }
}
