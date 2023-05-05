using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    internal class User
    {
        public string UserName { get; set; }
        public int Age { get; set; }
        public string[] Occupations { get; set; }
        public string Description { get; set; }

        public User(string username, int age, string[] occupations, string description)
        {
            UserName = username;
            Age = age;
            Occupations = occupations;
            Description = description;
        }
    }
}
