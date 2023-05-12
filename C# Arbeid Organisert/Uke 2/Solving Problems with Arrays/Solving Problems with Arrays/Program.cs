using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Solving_Problems_with_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] regularAlphabet = RegularAlphabet();
            char[] cipherAlphabet = CipherAlphabet();

            Console.WriteLine("\r\nPlease enter the text you want to encode:");
            string plainText = Console.ReadLine();

            string cipherText = EncodeUserText(plainText, cipherAlphabet, regularAlphabet);
            Console.WriteLine("\r\nHere is your complete encoded message using the cipher!");
            Console.Write(cipherText);
            Console.ReadLine();
        }

        private static char[] CipherAlphabet()
        {
            var letters = new char[26];
            var letter = new Random().Next('B', 'Z');

            Console.WriteLine("In this cipher there is a " + (letter - 'A') + " letter difference."
                              + "\r\nThis means that 'A' = " + "'" + (Convert.ToChar('A' + (letter - 'A')) + "'")
                              + "\r\nAny sign outside of the alphabet will be shown as their ASCII number and blank spaces as '-'"
            );

            for (var index = 0; index < letters.Length; index++)
            {
                var c = letters[index];
                letter++;
                if (letter > 'Z') letter = 'A';
                letters[index] = Convert.ToChar(letter);
            }

            return letters;
        }

        private static char[] RegularAlphabet()
        {
            var letters = new char[26];

            for (var index = 0; index < letters.Length; index++) letters[index] = Convert.ToChar('A' + index);

            return letters;
        }

        static string EncodeUserText(string plainText, char[] cipherAlphabet, char[] regularAlphabet)
        {
            string cipherText = "";

            foreach (char c in plainText)
            {
                if (c == ' ')
                {
                    char index = '-';
                    cipherText += index;
                }
                else if (char.ToUpper(c) >= 'A' && char.ToUpper(c) <= 'Z')
                {
                    var index = regularAlphabet.ToList().FindIndex(x => x.Equals(char.ToUpper(c)));
                    cipherText += cipherAlphabet[index];
                }
                else
                {
                    int index = Convert.ToInt32(c);
                    cipherText += index;
                }

            }

            return cipherText;
        }
    }
}