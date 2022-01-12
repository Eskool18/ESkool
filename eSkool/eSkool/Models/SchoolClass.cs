using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            ClassTeachers = new HashSet<ClassTeacher>();
            Students = new HashSet<Student>();
        }

        public int ClassGrade { get; set; }
        public string ClassName { get; set; }
        public string Incharge { get; set; }

        public virtual ICollection<ClassTeacher> ClassTeachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
