using System;
using System.Collections.Generic;

#nullable disable

namespace eSkool.Models
{
    public partial class UserInfo
    {

        public UserInfo()
        {

        }

        public UserInfo(string userName, string role)
        {
            this.UserName = userName;
            this.Password = role;
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
