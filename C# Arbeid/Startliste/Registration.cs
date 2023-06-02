using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startliste
{
    internal class Registration
    {
        private string _startNumber;
        private string _name;
        private string _club;
        private string _nationality;
        private string _group;
        private string _class;

        public Registration(string num, string name, string club, string nationality, string group, string newClass)
        {

            _startNumber = num;
            _name = name;
            _club = club;
            _nationality = nationality;
            _group = group;
            _class = newClass;
        }
    }
}
