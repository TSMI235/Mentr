using System;
using System.Collections.Generic;
using System.Text;
using Mentr.Models;
using System.Collections.ObjectModel;

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
              Username = "MikeTheTiger",
              Password = "Password",
              Name = "Mike The Tiger",
              Age = 40,
              Picture = "https://pbs.twimg.com/profile_images/1044310634899345409/ANRR6Ko3_400x400.jpg",
              Field = "CSC",
              UserType = "Mentee",
              Email = "MikeTheTiger@lsu.edu",
              College = "Louisiana State University",
              Description = "Senior student in Computer Science",
              ResearchInterest = "Machine Learning and Artificial Intelligence",
          };
       }
        public ObservableCollection<User> GetMatches()
        {
            ObservableCollection<User> matches = new ObservableCollection<User>();
            matches.Add(new User
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
            });
            matches.Add(new User
            {
                Username = "Brener",
                Password = "pass123",
                Name = "Nathan Brener",
                Age = 40,
                Picture = "https://www.lsu.edu/eng/cse/people/faculty/photos/nathan.brener.jpg",
                Field = "CSC",
                UserType = "Mentor",
                Email = "brener@lsu.edu",
                College = "Louisiana State University",
                Description = "Ph.D. in Computer Science",
                ResearchInterest = "Predictive Intelligence, Artificial Intelligence, Route Planning Algorithms, Scientific Computing, Parallel Processing",
            });
            matches.Add(new User
            {
                Username = "Nash",
                Password = "pass123",
                Name = "Nash Mahmoud",
                Age = 40,
                Picture = "https://www.lsu.edu/eng/cse/people/faculty/photos/anas.mahmoud.jpg",
                Field = "CSC",
                UserType = "Mentor",
                Email = "mahmoud@csc.lsu.edu",
                College = "Louisiana State University",
                Description = "Ph.D. in Computer Science and Engineering, Mississippi State University, 2014",
                ResearchInterest = "Software Engineering, Requirements Engineering, Program Comprehension, and Code Analysis",
            });
            matches.Add(new User
            {
                Username = "Lee",
                Password = "pass123",
                Name = "Kisung Lee",
                Age = 40,
                Picture = "https://www.lsu.edu/eng/cse/people/faculty/photos/kisung.lee.jpg",
                Field = "CSC",
                UserType = "Mentor",
                Email = "lee@csc.lsu.edu",
                College = "Louisiana State University",
                Description = "Ph.D. in Computer Science, Georgia Institute of Technology, Atlanta, Georgia",
                ResearchInterest = "Scaling big data analytics, cloud computing, distributed computing systems.",
            });
            matches.Add(new User
            {
                Username = "Zhang",
                Password = "pass123",
                Name = "Jian Zhang",
                Age = 40,
                Picture = "https://www.lsu.edu/eng/cse/people/faculty/photos/jian.zhang.jpg",
                Field = "CSC",
                UserType = "Mentor",
                Email = "zhang@csc.lsu.edu",
                College = "Louisiana State University",
                Description = "Ph.D. in Computer Science, Yale University, 2005",
                ResearchInterest = "Machine Learning and Applications",
            });
            return matches;
        }
    }
}
