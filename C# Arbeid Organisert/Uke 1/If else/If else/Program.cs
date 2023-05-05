using System.Numerics;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first number");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var equal = checkIfEqualBoolean(num1, num2);
            var equal2 = checkIfEqualInterger(num1, num2);
            var equal3 = checkIfSumEquals30(num1, num2);

            Console.WriteLine("The numbers are the same: " + equal);
            Console.WriteLine("Big brain calculation tells me your lucky number is " + equal2);
            Console.WriteLine("The numbers equal 30: " + equal3);
        }

        static bool checkIfEqualBoolean(int num1, int num2)
        {
            if (num1 == num2) return true;
            else return false;
        }
        static int checkIfEqualInterger(int num1, int num2)
        {
            if (num1 != num2) return num1 + num2;
            else return num1 * num2;
        }

        static bool checkIfSumEquals30(int num1, int num2)
        {
            if (num1 + num2 == 30) return true;
            else return false;
        }
    }
}