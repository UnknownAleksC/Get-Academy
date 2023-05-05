using System.Reflection.Metadata;

namespace Jobb_Fabrikk_Uke_1_Pensum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userAnswer = "Test";
            while (!string.IsNullOrWhiteSpace(userAnswer))
            {
                Console.Write("Insert your name: ");
                userAnswer = Console.ReadLine();
                Console.WriteLine(getJob(userAnswer));
            }
        }

        static string getJob(string userAnswer)
        {
            string[] jobs = { 
                "Congratulations " + userAnswer + " you are now an astronaut!", 
                "By the power invested in me, " + userAnswer + " is now a mother hen!",
                "G-g-g-gosh " + userAnswer + "! You just became the new face of Disney!"
            };
            int num = randomNum();
            string jobTitle = jobs[num];

            return jobTitle;
        }

        static int randomNum()
        {
            Random rand = new Random();
            return rand.Next(0, 3);
        }
    }
}