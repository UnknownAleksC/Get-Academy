using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startliste
{
    internal class Club
    {
        private string _name;
        private List<Registration> _registrations;

        public Club(string name)
        {
            _name = name;
        }
        public Club(List<Registration> registrations)
        {
            _registrations = registrations;
        }

        public string GetName()
        {
            return _name;
        }

        public void AddRegistration(List<Registration> registrations)
        {
            _registrations = registrations;
        }
    }
}
