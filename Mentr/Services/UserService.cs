using System;
using System.Collections.Generic;
using System.Text;
using Mentr.Models;

namespace Mentr.Services
{
    class UserService
    {
        private static UserService instance;

        public static UserService Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserService();
                return instance;
            }
        }

        public User GetTestUser()
        {
            return new User
            {
                Name = "William Duncan",
                Picture = "Duncan",
                University = "Louisiana State University",
                Description = "Computer Science Professor",
                Mentees = new List<User>
                {
                    //Null for now
                },
                Mentors = new List<User>
                {
                    //Null for now
                }

            };
        }
    }
}
