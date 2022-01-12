using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            ClassTeachers = new HashSet<ClassTeacher>();
        }

        public string TeacherId { get; set; }
        public string Designation { get; set; }
        public int? Salary { get; set; }
        public string Education { get; set; }
        public string Gender { get; set; }
        public string TeacherName { get; set; }
        public string TeacherCnic { get; set; }
        public string Experience { get; set; }

        public virtual ICollection<ClassTeacher> ClassTeachers { get; set; }
    }
}
