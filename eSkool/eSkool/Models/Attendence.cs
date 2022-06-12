using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Attendence
    {
        
        public int AttendenceId { get; set; }
        public string StudentId { get; set; }
        public DateTime? AttendenceDate { get; set; }
        public string ClassName { get; set; }
        public int? AttendenceStatus { get; set; }
    }
}
