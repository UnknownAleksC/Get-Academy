using MatchingMinigame;
internal class PlayerFlag : Flag
{
    public override ConsoleKey? GetDirection()
    {
        try
        {
            _direction = reader.ReadLine();
            return _direction;
        }
        catch (TimeoutException)
        {
            _direction = null;
            return _direction;
        }
    }
}