using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private void Awake()
    {
        GameStartEvent.Register(OnGameStart);
    }
    private void OnGameStart()
    {
        transform.Find("Enemy").gameObject.SetActive(true);
    }
    private void OnDestroy()
    {
        GameStartEvent.UnRegister(OnGameStart);
    }
}

