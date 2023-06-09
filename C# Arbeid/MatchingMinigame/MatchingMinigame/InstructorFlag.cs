namespace MatchingMinigame
{
    internal class InstructorFlag : Flag
    {
        private List<ConsoleKey> _keys =
            new()
            {
                ConsoleKey.UpArrow,
                ConsoleKey.DownArrow,
                ConsoleKey.RightArrow,
                ConsoleKey.LeftArrow
            };
        public override ConsoleKey GetDirection()
        {
            var rNum = new Random().Next(0, _keys.Count);
            _direction = _keys[rNum];
            return _direction;
        }
    }
}
