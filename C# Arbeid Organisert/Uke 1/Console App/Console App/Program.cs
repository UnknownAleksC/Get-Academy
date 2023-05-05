using System.Numerics;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Xml.Schema;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            //Console.SetCursorPosition(11, 20);
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    if ((int)character >= 97 && (int)character <= 122)
                    {
                        counts[(int)character - 32]++;
                    }
                    else
                    {
                        counts[(int)character]++;
                    }
                }

                for (var i = 0; i < counts.Length; i++)
                {
                    if (counts[i] > 0)
                    {
                        int sum = (int)Math.Round((double)(100 * counts[i]) / counts.Sum());
                        var character = (char)i;
                        var outputText = "\"" + character + "\" - " + sum + "% - " + counts[i];
                        Console.CursorLeft = Console.BufferWidth - outputText.Length;
                        Console.WriteLine(outputText);
                    }
                }
            }
        }
    }
}