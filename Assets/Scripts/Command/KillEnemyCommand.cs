public struct KillEnemyCommand : ICommand
{
    public void Execute()
    {
        var gamemode = PointGame.Get<IGameModel>();

        gamemode.KillCount.Value++;

        if (gamemode.KillCount.Value == 9)
        {
            GamePassEvent.Trigger();
        } 
    }
}
