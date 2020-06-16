using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _123
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Level Level { get; set; }

        
        public Users() { }

        public Users(string username, string password)
        {
            Username = username;
            Password = password;
            Level = Level.User;
        }
    }
}
