using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class QuestionTypesInfo
    {
        public int QuestionTypeId { get; set; }
        public string CourseId { get; set; }
        public int? ClassGrade { get; set; }
        public string SubjectName { get; set; }
        public string TypeDescription { get; set; }

        public virtual SubjectsInfo SubjectsInfo { get; set; }
    }
}
