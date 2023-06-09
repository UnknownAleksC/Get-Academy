using System.Linq;
using System.Runtime.InteropServices;

namespace Startliste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startList = File.ReadAllLines("startlist.csv");
            var registrationList = new List<Registration>();
            var clubList = new List<Club>();

            foreach (var line in startList)
            {
                string newLine = line.Replace("\"", "");
                var lineSeperated = newLine.Split(",");
                var newRegistration = new Registration(
                    lineSeperated[0],
                    lineSeperated[1],
                    lineSeperated[2],
                    lineSeperated[3],
                    lineSeperated[4],
                    lineSeperated[5]
                );

                //Legger til alle registreringer i en liste
                registrationList.Add(newRegistration);

                //Sjekker om en club eksisterer og om den ikke gjør det legger den cluben til
                if (clubList.Find(x => x.GetName() == lineSeperated[2]) == null)
                {
                    clubList.Add(new Club(lineSeperated[2]));
                    clubList.Last().AddRegistration(newRegistration);
                }
                else
                    clubList.First(x => x.GetName() == lineSeperated[2]).AddRegistration(newRegistration);
            }

            // Legger registrationlist til hver club
            foreach (var club in clubList)
            {
                club.WriteOutRegisteredUsers();
            }
        }
    }
}