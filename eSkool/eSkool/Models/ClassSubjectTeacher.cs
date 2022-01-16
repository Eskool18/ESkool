using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class ClassSubjectTeacher
    {
        public int? ClassGrade { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string TeacherId { get; set; }
        public int ClassSubjectId { get; set; }

        public virtual SchoolClass Class { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
