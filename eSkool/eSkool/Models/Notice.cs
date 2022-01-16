using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Notice
    {
        public int NoticeId { get; set; }
        public string NoticeStatement { get; set; }
        public DateTime? NoticeLastDate { get; set; }
        public DateTime? NoticeFromDate { get; set; }
    }
}
