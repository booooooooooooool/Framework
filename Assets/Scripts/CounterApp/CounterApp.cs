public class CounterApp : Architecture<CounterApp>
{
    protected override void Init()
    {
        RegisterModel<ICounterModel>(new CountModel());
        RegisterUtility<IStorage>(new PlayerPrefsStorage());
    }
}
