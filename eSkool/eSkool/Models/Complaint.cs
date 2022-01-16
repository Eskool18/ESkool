using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Complaint
    {
        public int ComplaintId { get; set; }
        public string UserName { get; set; }
        public DateTime? ComplaintDate { get; set; }
        public string ComplaintStatement { get; set; }

        public virtual Teacher UserName1 { get; set; }
        public virtual Student UserNameNavigation { get; set; }
    }
}
