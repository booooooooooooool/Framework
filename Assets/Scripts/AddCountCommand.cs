public struct AddCountCommand : ICommand
{
    public void Execute()
    {
        CountModel.Instance.Count.Value++;
    }
}
