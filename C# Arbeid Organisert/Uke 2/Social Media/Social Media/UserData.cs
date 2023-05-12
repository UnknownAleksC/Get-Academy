namespace Social_Media
{
    public class UserData
    {
        public static List<User> CreateUsers()
        {
            var philUser = new User("Phil", 32, "Fisherman", "Very fishy");
            var tomUser = new User("Tom", 22, "Lion tamer", "Come closer, I don't bite");

            var samUser = new User("Sam", 21, "Professional street fighter",
                "\u2191\u2191\u2193\u2193\u2190\u2192\u2190\u2192BA");

            var maritaUser = new User("Marita", 72, "Marathoner", "Can't stop, won't stop");
            var magneUser = new User("Magne", 36, "Kidney seller", "5000$ SALE LASTING OUT JUNE!");
            var sophieUser = new User("Sophie", 27, "Farmer", "It's simple, a farmers life that is");

            var users = new List<User>();
            users.Add(philUser);
            users.Add(tomUser);
            users.Add(samUser);
            users.Add(maritaUser);
            users.Add(magneUser);
            users.Add(sophieUser);

            return users;
        }
    }

    public class CustomFunctions
    {
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            int windowWidth = Console.WindowWidth;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void TypeLine(string line, int timeout)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(timeout); 
            }
            Console.WriteLine();
        }

        public static void TypeSameLine(string line, int timeout)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(timeout); 
            }
        }
    }

}