using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterViewController : MonoBehaviour
{
    private Button BtnAdd;
    private Button BtnSub;
    private void Awake()
    {
        BtnAdd = transform.Find("BtnAdd").GetComponent<Button>();
        BtnSub = transform.Find("BtnSub").GetComponent<Button>();

    }
    private void Start()
    {
        CountModel.Instance.Count.OnValueChanged += OnCountChange;

        OnCountChange(CountModel.Instance.Count.Value);

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
        CountModel.Instance.Count.OnValueChanged -= OnCountChange;
    }

}
public class CountModel : Singleton<CountModel>
{
    private CountModel() { }

    public BindableProperty<int> Count = new BindableProperty<int>()
    {
        Value = 0
    };
}
