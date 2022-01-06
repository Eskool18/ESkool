using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class ChaptersInfo
    {
        public ChaptersInfo()
        {
            ExercisesInfos = new HashSet<ExercisesInfo>();
        }

        public string CourseId { get; set; }
        public int ClassGrade { get; set; }
        public string SubjectName { get; set; }
        public string ChapterName { get; set; }
        public int? TotalExercise { get; set; }

        public virtual SubjectsInfo SubjectsInfo { get; set; }
        public virtual ICollection<ExercisesInfo> ExercisesInfos { get; set; }
    }
}
