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
              Username = "Duncant",
              Password = "pass123",
              Name = "William Duncan",
              Age = 40,
              Picture = "https://www.lsu.edu/eng/cse/people/faculty/photos/william.duncan.jpg",
              Field = "CSC",
              UserType = "Mentor",
              Email = "duncan@lsu.edu",
              College = "Louisiana State University",
              Description = "Ph.D. in Computer Science",
              ResearchInterest = "Knowledge Discovery and Data Mining, Bioinformatics, Stochastic Process and Markov Chains",
          };
       }
    }
}
