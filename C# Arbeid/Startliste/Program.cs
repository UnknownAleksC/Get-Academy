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
                //line.Trim(new Char[] { ',', '\"' });
                var lineSeperated = line.Split(",");
                var newRegistration = new Registration(
                    lineSeperated[0].Trim(new Char[] { ' ', ',', '\"' }),
                    lineSeperated[1],
                    lineSeperated[2],
                    lineSeperated[3],
                    lineSeperated[4],
                    lineSeperated[5]
                );
                registrationList.Add(newRegistration);
                if (clubList.Find(x => x.GetName() == lineSeperated[2]) == null)
                    clubList.Add(new Club(lineSeperated[2]));
            }

            foreach (var club in clubList)
            {
                club.AddRegistration(registrationList);
            }
        }
    }
}