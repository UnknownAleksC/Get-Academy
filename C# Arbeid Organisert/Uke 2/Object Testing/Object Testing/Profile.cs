using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Testing
{
    internal class Profile
    {
        public string Name { get; set; }
        public Profile() { }

        public Profile(string name)
        {
            Name = name;
        }
    }
}
