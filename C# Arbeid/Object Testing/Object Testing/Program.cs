using Object_Testing;

var socialMediaAccounts = new List<Profile>();
socialMediaAccounts.Add(new Profile("Thor"));
socialMediaAccounts.Add(new Profile("Oda"));

var mainProfile = new Profile("Johan");
PrintMenu();
var input  = Console.ReadLine();

void PrintMenu()
{
    Console.WriteLine($"Welcome to Howler {mainProfile.Name}");
    Console.WriteLine("1. Add Friend");
    Console.WriteLine("2. Remove Friend");
    Console.WriteLine("3. Print Friends");
    Console.WriteLine("4. Show Friend Info");
}