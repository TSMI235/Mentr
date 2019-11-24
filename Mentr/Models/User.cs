using System;
using System.Collections.Generic;
using System.Text;

namespace Mentr.Models
{
    public class User
    {
        public string Name { get; set; }
        public string University { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public List<User> Mentors { get; set; }
        public List<User> Mentees { get; set; }
        public string Username;
        public string Password;
        public User() { }
        
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public Boolean CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
