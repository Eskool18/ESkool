using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public UserInfo(string username, string role)
        {
            UserName = username;
            Role = role;
            Password = "eskool";

        }
    }
}
