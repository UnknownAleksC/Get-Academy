using MatchingMinigame;

internal class Player : FlagHolder
{
    public override List<ConsoleKey?> GetFlagInputs(int amount)
    {
        var keyInputs = new List<ConsoleKey?>();
        Flags = new IFlag[amount];
        Flags = Flags.Select(_ => new PlayerFlag()).ToArray();
        foreach (var flag in Flags)
        {
            keyInputs.Add(flag.GetDirection());
            flag.PrintDirection();
        }
        Console.WriteLine();
        return keyInputs;
    }
}
