using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class SubjectsInfo
    {
        public SubjectsInfo()
        {
            ChaptersInfos = new HashSet<ChaptersInfo>();
            QuestionTypesInfos = new HashSet<QuestionTypesInfo>();
        }
        public string CourseId { get; set; }
        public int ClassGrade { get; set; }
        public string SubjectName { get; set; }
        public int? TotalChapter { get; set; }
        public virtual ClasssesInfo C { get; set; }
        public virtual ICollection<ChaptersInfo> ChaptersInfos { get; set; }
        public virtual ICollection<QuestionTypesInfo> QuestionTypesInfos { get; set; }
    }
}
