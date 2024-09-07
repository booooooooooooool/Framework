public struct SubCountCommand : ICommand
{
    public void Execute()
    {
        CounterApp.Get<CountModel>().Count.Value--;
    }
}
