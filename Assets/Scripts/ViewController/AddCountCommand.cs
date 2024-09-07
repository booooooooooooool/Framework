public struct AddCountCommand : ICommand
{
    public void Execute()
    {
        CounterApp.Get<CountModel>().Count.Value++;
    }
}
