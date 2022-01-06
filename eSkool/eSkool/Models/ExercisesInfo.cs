using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class ExercisesInfo
    {
        public int UniqueSyllabusId { get; set; }
        public string CourseId { get; set; }
        public int? ClassGrade { get; set; }
        public string SubjectName { get; set; }
        public string ChapterName { get; set; }
        public string ExerciseName { get; set; }

        public virtual ChaptersInfo ChaptersInfo { get; set; }
    }
}
