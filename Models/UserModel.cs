using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_Login_Form.Models
{
    public class UserModel
    {
        // user attributes
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password{ get; set; }


        // construtor with default parameter
        public UserModel()
        {
            Username = "Nothing";
            Password = "Nothing";
        }

        // constructor with no default parameter
        public UserModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        



    }
}