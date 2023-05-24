namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Hero = new GameCharacter("Benjamin", 200, 20, 40);
            var Boss = new GameCharacter("Benjaman", 200, 15, 10);

            bool bossTurn = false;
            bool bossFight = true;
            while (bossFight)
            {
                var random = new Random();
                Boss.Strength = random.Next(0, 31);
                Console.Write($"|Player ({Hero.Name}):\r\n" +
                              $"|HP - {Hero.Health}\r\n" +
                              $"|Strength - {Hero.Strength}\r\n" +
                              $"|Stamina - {Hero.Stamina}\r\n");
                Console.SetCursorPosition(Hero.Name.Length + 15, Console.CursorTop - 4);
                Console.Write($"| Boss ({Boss.Name}):\r\n");
                Console.SetCursorPosition(Hero.Name.Length + 15, Console.CursorTop);
                Console.Write($"| HP - {Boss.Health}\r\n");
                Console.SetCursorPosition(Hero.Name.Length + 15, Console.CursorTop);
                Console.Write($"| Strength - {Boss.Strength}\r\n");
                Console.SetCursorPosition(Hero.Name.Length + 15, Console.CursorTop);
                Console.WriteLine($"| Stamina - {Boss.Stamina}");
                Console.WriteLine($"\r\nPick an action:" +
                                  $"\r\nFight | Recharge");
                bool bossRound = true;
                while (bossRound)
                {
                    if (!bossTurn)
                    {
                        string userInput = Console.ReadLine();
                        if (userInput == "Fight")
                        {
                            Hero.Fight(Hero, Boss);
                            bossRound = false;
                            bossTurn = true;
                        }
                        else if (userInput == "Recharge")
                        {
                            Hero.Recharge(Hero);
                            bossRound = false;
                            bossTurn = true;
                        }
                        else
                        {
                            Console.WriteLine("\r\nInvalid user input! Please try again");
                            continue;
                        }
                    }
                    else
                    {
                        if (Boss.Stamina == 0)
                        {
                            Boss.Recharge(Boss);
                            bossRound = false;
                            bossTurn = false;
                        }
                        else
                        {
                            Boss.Fight(Boss, Hero);
                            bossRound = false;
                            bossTurn = false;
                        }
                    }

                    Console.ReadLine();
                    Console.Clear();
                    if (Hero.Health <= 0)
                    {
                        Console.WriteLine("Oh no you lost! The kingdom is doomed!");
                        bossFight = false;
                        Console.ReadLine();
                    }
                    else if (Boss.Health <= 0)
                    {
                        Console.WriteLine("Hurray, you won! The kingdom is saved!");
                        bossFight = false;
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}