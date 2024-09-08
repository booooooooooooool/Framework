using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterViewController : MonoBehaviour
{
    private Button BtnAdd;
    private Button BtnSub;

    private ICounterModel mCountModel;
    private void Awake()
    {
        BtnAdd = transform.Find("BtnAdd").GetComponent<Button>();
        BtnSub = transform.Find("BtnSub").GetComponent<Button>();

    }
    private void Start()
    {
        mCountModel = CounterApp.Get<ICounterModel>();

        mCountModel.Count.OnValueChanged += OnCountChange;

        OnCountChange(mCountModel.Count.Value);

        BtnAdd.onClick.AddListener(() =>
        {
            new AddCountCommand()
                .Execute();
        });
        BtnSub.onClick.AddListener(() =>
        {
            new SubCountCommand()
                .Execute();
        });
    }

    private void OnCountChange(int newCount)
    {
        transform.Find("Count").GetComponent<Text>().text = newCount.ToString();
    }

    private void OnDestroy()
    {
        mCountModel.Count.OnValueChanged -= OnCountChange;

        mCountModel = null;
    }

}

public interface ICounterModel :IModel
{
    BindableProperty<int> Count { get;}
}
public class CountModel : ICounterModel
{
    public void Init()
    {   
        var storage = Architecture.GetUtility<IStorage>();

        Count.Value = storage.LoadInt("COUNTER_COUNT", 0);
        Count.OnValueChanged += count =>
        {
            storage.SaveInt("COUNTER_COUNT", count);
        };
    }
    public BindableProperty<int> Count { get; } = new BindableProperty<int>()
    {   
        Value = 0
    };
    public IArchitecture Architecture { get; set; }

}
