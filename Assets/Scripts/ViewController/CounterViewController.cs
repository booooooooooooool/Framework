using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterViewController : MonoBehaviour
{
    private Button BtnAdd;
    private Button BtnSub;

    private CountModel mCountModel;
    private void Awake()
    {
        BtnAdd = transform.Find("BtnAdd").GetComponent<Button>();
        BtnSub = transform.Find("BtnSub").GetComponent<Button>();

    }
    private void Start()
    {
        mCountModel = CounterApp.Get<CountModel>();

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
public class CountModel
{

    public BindableProperty<int> Count = new BindableProperty<int>()
    {
        Value = 0
    };
}
