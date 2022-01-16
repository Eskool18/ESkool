using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public string StudentId { get; set; }
        public string AppicationTitle { get; set; }
        public string ApplicationBody { get; set; }
        public DateTime? ApplicationFromDate { get; set; }
        public DateTime? ApplicationToDate { get; set; }
        public int? TotalDays { get; set; }
        public DateTime? SubmissionDate { get; set; }

        public virtual Student Student { get; set; }
    }
}
