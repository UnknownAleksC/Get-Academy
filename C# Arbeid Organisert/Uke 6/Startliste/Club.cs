using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            _registrations = new List<Registration>();
        }

        public string GetName()
        {
            return _name;
        }

        public void AddRegistration(Registration registration)
        {
            _registrations.Add(registration);
        }

        public void WriteOutRegisteredUsers()
        {
            if (_name is "")
                Console.WriteLine($"There are {_registrations.Count} total people not registered in a club");
            else
            {
                Console.WriteLine($"There are {_registrations.Count} total registered members in the {_name} club");

                var classes = new List<string>();
                foreach (Registration registration in _registrations)
                {
                    if (!classes.Contains(registration.Class))
                    {
                        classes.Add(registration.Class);
                        int classAmount = _registrations.FindAll(x => x.Class == registration.Class).Count;
                        Console.WriteLine($"There are also {classAmount} total members with the class {registration.Class}");
                    }
                }
            }
        }
    }
}
