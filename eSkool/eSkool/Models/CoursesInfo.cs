using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class CoursesInfo
    {
        public CoursesInfo()
        {
            ClasssesInfos = new HashSet<ClasssesInfo>();
        }

        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int? TotalClasses { get; set; }

        public virtual ICollection<ClasssesInfo> ClasssesInfos { get; set; }
    }
}
