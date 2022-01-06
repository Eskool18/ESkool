using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class ClasssesInfo
    {
        public ClasssesInfo()
        {
            SubjectsInfos = new HashSet<SubjectsInfo>();
        }

        public string CourseId { get; set; }
        public int ClassGrade { get; set; }
        public string TotalSubject { get; set; }

        public virtual CoursesInfo Course { get; set; }
        public virtual ICollection<SubjectsInfo> SubjectsInfos { get; set; }
    }
}
