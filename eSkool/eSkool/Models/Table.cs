using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class Table
    {
        public int ActiveId { get; set; }
        public string Username { get; set; }
        public DateTime? PeTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
