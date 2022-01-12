using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class QuestionBank
    {
        public int QuestionId { get; set; }
        public int UniqueSyllabusId { get; set; }
        public int? QuestionTypeId { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionNature { get; set; }
        public string QuestionStatement { get; set; }
    }
}
