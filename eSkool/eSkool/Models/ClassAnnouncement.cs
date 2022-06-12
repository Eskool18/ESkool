using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class ClassAnnouncement
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Subject { get; set; }
        public string ClassName { get; set; }
        public string Content { get; set; }
        public DateTime? PostDate { get; set; }
        public string Username { get; set; }
    }
}
