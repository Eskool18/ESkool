using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class HelpingMeterial
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public int? MaterialClass { get; set; }
        public string MaterialType { get; set; }
        public string MaterialSubject { get; set; }
        public string UserName { get; set; }
    }
}
