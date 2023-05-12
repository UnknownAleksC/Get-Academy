namespace Social_Media;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.BackgroundColor
        //    = ConsoleColor.Blue;
        var users = UserData.CreateUsers();
        var newUser = new User();

        //Console.ForegroundColor = ConsoleColor.Green;
        //CustomFunctions.TypeLine("Welcome to our social media platform!", 100);
        //CustomFunctions.TypeSameLine("My scientific name is ", 100);
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.Write("F.R.I.E.N.D");
        //Thread.Sleep(100);
        //CustomFunctions.ClearCurrentConsoleLine();
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write("My scientific name is F.R.I.E.N.D");
        //CustomFunctions.TypeLine(" but you can call me Buddy :)", 100);
        //CustomFunctions.TypeLine("I will be your guide to this wacky new virtual world!", 100);
        //CustomFunctions.TypeSameLine("To start, why don't you provide me with some ", 100);
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.Write("PERSONAL");
        //Thread.Sleep(100);
        //CustomFunctions.ClearCurrentConsoleLine();
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Write("To start, why don't you provide me with some key");
        //CustomFunctions.TypeLine(" information so we can make you a profile!", 100);
        //Console.WriteLine();
        //CustomFunctions.TypeSameLine("Insert your name: ", 100);
        //newUser.UserName = Console.ReadLine();

        //Console.SetCursorPosition(0, Console.CursorTop - 1);
        CustomFunctions.ClearCurrentConsoleLine();
        Thread.Sleep(400);
        Console.Write("Computing ");
        CustomFunctions.TypeSameLine("...", 800);
        CustomFunctions.ClearCurrentConsoleLine();
        Console.Write("Computing ");
        CustomFunctions.TypeSameLine("...", 800);
        CustomFunctions.ClearCurrentConsoleLine();
        Thread.Sleep(800);
        CustomFunctions.TypeSameLine("Thank you for the information :)", 100);
        Thread.Sleep(500);
        CustomFunctions.ClearCurrentConsoleLine();
        Console.Write("Insert your age: ");
        newUser.Age = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        CustomFunctions.ClearCurrentConsoleLine();
        Thread.Sleep(400);
        Console.Write("Computing ");
        CustomFunctions.TypeSameLine("...", 800);
        CustomFunctions.ClearCurrentConsoleLine();
        Console.Write("Computing ");
        CustomFunctions.TypeSameLine("...", 800);
        CustomFunctions.ClearCurrentConsoleLine();
        Thread.Sleep(800);
        CustomFunctions.TypeSameLine("Much obliged :)", 100);
        Thread.Sleep(500);
        CustomFunctions.ClearCurrentConsoleLine();
        Console.WriteLine("Insert your occupation: ");
        newUser.Occupation = Console.ReadLine();
    }

    //private int getAge()
    //{
    //    bool done = false;
    //    var age = Console.ReadLine();
    //    while (done != true)
    //    {
    //        if (age == null) 
    //        foreach (char c in age)
    //        {

    //        }
    //    }
    //};
}