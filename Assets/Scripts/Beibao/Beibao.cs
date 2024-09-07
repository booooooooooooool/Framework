using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Beibao : MonoBehaviour
{
    public List<Button> bbtManager = new List<Button>();
    public bool isSelect = false;
    public int select_b;
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            bbtManager.Add(transform.GetChild(i).GetComponent<Button>());
            bbtManager[i].onClick.AddListener(delegate
            {
                if (isSelect)
                {
                    isSelect = false;
                    return;
                }
                isSelect = true;
                select_b = i;
            });
        }
    }
    private void Update()
    {

    }
}
