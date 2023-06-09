using MatchingMinigame;

internal class Player : FlagHolder
{
    public override List<ConsoleKey> GetFlagInputs(int amount)
    {
        var keyInputs = new List<ConsoleKey>();
        _flags = new IFlag[amount];
        _flags = _flags.Select(_ => new PlayerFlag()).ToArray();
        foreach (var flag in _flags)
        {
            keyInputs.Add(flag.GetDirection());
        }
        return keyInputs;
    }
}
