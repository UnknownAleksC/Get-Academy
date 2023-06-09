using MatchingMinigame;
internal class PlayerFlag : Flag
{
    public override ConsoleKey GetDirection()
    {
        _direction = Console.ReadKey().Key;
        return _direction;
    }
}