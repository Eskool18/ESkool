using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eSkool.Models
{
    public partial class UserInfo
    {
        

        public int Id { get; set; }

        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
