public struct KillEnemyCommand : ICommand
{
    public void Execute()
    {
        GameModel.Instance.KillCount.Value++;

        if (GameModel.Instance.KillCount.Value == 9)
        {
            GamePassEvent.Trigger();
        } 
    }
}
