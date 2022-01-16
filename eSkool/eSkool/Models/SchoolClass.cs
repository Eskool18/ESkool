using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            ClassSubjectTeachers = new HashSet<ClassSubjectTeacher>();
            Students = new HashSet<Student>();
        }

        public int ClassGrade { get; set; }
        public string ClassName { get; set; }
        public string Incharge { get; set; }
        public int? TotalStudent { get; set; }

        public virtual ICollection<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
