using MatchingMinigame;
internal class MatchGame
{
    private Player _player = new Player();
    private Instructor _instructor = new Instructor();

    public void RunGame()
    {
        _instructor.GetFlagInputs(10);
        _player.GetFlagInputs(10);
    }
}