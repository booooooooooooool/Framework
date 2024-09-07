using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;


// delegate void MyDelegate (string s);
public class talk : MonoBehaviour
{

    //选择对话块
    //对话块
    class abc
    {
        public status mstatus;
        public Func<bool> triggertiaojian;

        public string[] texts;
        public int textindex;
        public Action talkliuchengfun;
    }

    List<abc> lists = new List<abc>();
    bool isNear;
    // public string[] qianzhitalktexts = {
    //     "交谈",
    //     "交易"
    // };
    public string[] talktests = {
    "这是第一句话",
    "这是第二句话",
    "这是第三句话"
  };
    public enum status //状态
    {
        first,
        richang
    }
    bool isFirst = true;
    // Start is called before the first frame update
    void Start()
    {
        abc firsttext = new abc();
        firsttext.mstatus = status.first;
        firsttext.triggertiaojian = () =>
        {
            return isFirst;
        };
        firsttext.talkliuchengfun = () =>
        {
            isFirst = false;
            Debug.Log("第一次");
        };
        firsttext.texts = talktests;
        abc richangtext = new abc();
        richangtext.mstatus = status.richang;
        richangtext.triggertiaojian = () =>
        {
            return false;
        };
        richangtext.talkliuchengfun = () =>
        {
            print(firsttext.texts[firsttext.textindex++]);
            if (firsttext.textindex >= firsttext.texts.Length)
            {
                firsttext.textindex = 0;
            }
        };

        lists.Add(firsttext);
        lists.Add(richangtext);
    }

    public void a(UnityAction callback)
    {
        // a();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            for (int i = 0; i < lists.Count; ++i)
            {
                if (lists[i].triggertiaojian())
                {
                    lists[i].talkliuchengfun();
                    break;
                }
            }
        }
    }
}
        // a(delegate(){

    