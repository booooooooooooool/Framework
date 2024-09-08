public class PointGame
{
    private static IOCContainer mContainer;

    static void MakeSureContainer()
    {
        if (mContainer == null)
        {
            mContainer = new IOCContainer();
            Init();
        }
    }

    static void Init()
    {
        mContainer.Register<IGameModel>(new GameModel());   
    }

    public static T Get<T>() where T : class
    {
        MakeSureContainer();
        return mContainer.Get<T>();
    }
}
