namespace Testing
{
    internal class Program
    {
        private static string Log = "[<LEVEL>]: <MESSAGE>";
        static void Main(string[] args)
        {
            var Log1 = new LogAnalysis("[INFO]: File Deleted.");
            var Log2 = new LogAnalysis("[INFO]: File Deleted.");
            var Log3 = new LogAnalysis("[ERROR]: Missing ; on line 20.");
            var Log4 = new LogAnalysis("[ERROR]: Missing ; on line 20.");

            Log1.SubstringAfter(": ");
        }
    }
}