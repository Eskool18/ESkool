using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class ClassTeacher
    {
        public int ClassGrade { get; set; }
        public string ClassName { get; set; }
        public string TeacherId { get; set; }

        public virtual SchoolClass Class { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
