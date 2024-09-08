using System;
using System.Collections.Generic;
using Unity.VisualScripting;

public interface IArchitecture
{
    void RegisterModel<T>(T model) where T : IModel;

    void RegisterUtility<T>(T Utility);

    T GetUtility<T>() where T : class;  
}

public abstract class Architecture<T> : IArchitecture where T : Architecture<T>, new()
{   
    /// <summary>
    /// 是否初始化完成
    /// </summary>
    private bool mIntied = false;

    private List<IModel> mModels = new List<IModel>();

    public static Action<T> OnRegisterPatch = architecture => { };

    private static T mArchitecture;

    static void MakeSureArchitecture()
    {
        if (mArchitecture == null)
        {
            mArchitecture = new T();
            mArchitecture.Init();

            OnRegisterPatch?.Invoke(mArchitecture);

            foreach(var architectureModel in mArchitecture.mModels)
            {
                architectureModel.Init();
            }

            mArchitecture.mModels.Clear();

            mArchitecture.mIntied = true;
        }
    } 

    protected abstract void Init();

    private IOCContainer mContainer = new IOCContainer();

    public static T Get<T>() where T : class
    {
        MakeSureArchitecture();

        return mArchitecture.mContainer.Get<T>();
    }

    public static void Register<T>(T instance)
    {
        MakeSureArchitecture();

        mArchitecture.mContainer.Register<T>(instance);
    }

    public void RegisterModel<T>(T model) where T : IModel
    {
        model.Architecture = this;
        mContainer.Register<T>(model);

        if(!mIntied)
        {
            mModels.Add(model);
        }
        else
        {
            model.Init();
        }
    }
    public T GetUtility<T>() where T : class
    {
        return mContainer.Get<T>();
    }

    public void RegisterUtility<T>(T utility)
    {
        mContainer.Register<T>(utility);
    }
}
