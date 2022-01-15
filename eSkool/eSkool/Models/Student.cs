using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Student
    {
        public string UserName { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public int? ClassGrade { get; set; }
        public string ClassName { get; set; }
        public string RollNumber { get; set; }
        public string StudentCnic { get; set; }
        public string ContactNumber1 { get; set; }
        public string ContactNumber2 { get; set; }
        public int? StudentAge { get; set; }
        public DateTime? AdmissionDate { get; set; }

        public virtual SchoolClass Class { get; set; }
    }
}
