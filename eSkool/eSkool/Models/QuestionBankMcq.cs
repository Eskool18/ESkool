using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class QuestionBankMcq
    {
        public int QuestionId { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectOption { get; set; }
    }
}
