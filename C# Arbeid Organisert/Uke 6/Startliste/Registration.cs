using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startliste
{
    internal class Registration
    {
        public string StartNumber { get; }
        public string Name { get; }
        public string Club { get; }
        public string Nationality { get; }
        public string Group { get; }
        public string Class { get; }

        public Registration(string num, string name, string club, string nationality, string group, string newClass)
        {

            StartNumber = num;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = group;
            Class = newClass;
        }
    }
}
