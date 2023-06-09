using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class LogAnalysis
    {
        static string Log;
        public LogAnalysis(string log)
        {
            Log = log;
        }


        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        public static string SubstringAfter(string splitString)
        {
            return Log.Substring(Log.IndexOf(splitString) + 2);
        }

        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(string startString, string endString)
        {
            int sIndex = Log.IndexOf(startString) + 1;
            int eIndex = Log.IndexOf(endString) - 1;
            return Log.Substring(sIndex, eIndex);
        }

        // TODO: define the 'Message()' extension method on the `string` type
        public static string Message()
        {
            string[] lines = Log.Split(":");
            return lines[1].Trim();
        }

        // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel()
        {
            string[] lines = Log.Split(":");
            return lines[0].Remove(lines[0].Length).Remove(0, 1);
        }
    }
}
