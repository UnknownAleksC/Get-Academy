using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MatchingMinigame
{
    internal class Reader
    {
        private static Thread _inputThread;
        private static AutoResetEvent _getInput, _gotInput;
        private static ConsoleKey _input;

        public Reader()
        {
            _getInput = new AutoResetEvent(false);
            _gotInput = new AutoResetEvent(false);
            _inputThread = new Thread(reader);
            _inputThread.IsBackground = true;
            _inputThread.Start();
        }

        static void reader()
        {
            while (true)
            {
                _getInput.WaitOne();
                _input = Console.ReadKey().Key;
                _gotInput.Set();
            }
        }

        public ConsoleKey ReadLine()
        {
            _getInput.Set();
            bool success = _gotInput.WaitOne(500);
            if (success)
                return _input;
            throw new TimeoutException("User did not submit input in time.");
        }
    }
}
