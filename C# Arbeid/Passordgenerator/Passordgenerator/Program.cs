using System.Reflection.Metadata.Ecma335;

namespace PassordGenerator
{
    internal class Program
    {
        static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                InstructionsForPassword();
            }
            else
            {
                var password = GeneratePassword(args);


                Console.WriteLine(@"Congratulations! Your new password is: "
                + password
                );
            }
        }

        private static string GeneratePassword(string[] args)
        {
            Console.WriteLine();
            var passwordLength = Convert.ToInt32(args[1]);
            var password = string.Empty;
            string options = args[2];
            foreach (var option in options)
            {
                if (option == 'l') password += GetLowerCaseLetter();
                else if (option == 'L') password += GetUpperCaseLetter();
                else if (option == 'd') password += GetDigit();
                else if (option == 's') password += GetSpecialCharacter();
            }

            ;

            for (int i = 0; i < (passwordLength - password.Length); i++)
            {
                password += (char)Random.Next(33, 126);
            }

            return password;
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 3) return false;

            foreach (var c in args[1])
            {
                if (!char.IsDigit(c)) return false;
            }

            foreach (var c in args[2])
            {
                if (c != 'l' && c != 'L' && c != 'd' && c != 's') return false;
            }

            return true;
        }

        private static char GetUpperCaseLetter()
        {
            return (char)Random.Next(65, 91);
        }
        private static char GetLowerCaseLetter()
        {
            return (char)Random.Next(97, 123);
        }
        private static int GetDigit()
        {
            return Random.Next(0, 10);
        }
        private static char GetSpecialCharacter()
        {
            int num = Random.Next(0, 3);

            if (num == 0) return (char)Random.Next(33, 48);
            if (num == 1) return (char)Random.Next(58, 65);
            if (num == 2) return (char)Random.Next(91, 97);
            return (char)Random.Next(123, 126);
        }



        private static void InstructionsForPassword()
        {
            Console.WriteLine(@"
PasswordGenerator  
Options:
- l = lower case letter
- L = upper case letter
- d = digit
- s = special character (!""#¤%&/(){}[]
Example: PasswordGenerator 14 lLssdd
Min. 1 lower case
Min. 1 upper case
Min. 2 special characters
Min. 2 digits
            ");
        }
    }
}