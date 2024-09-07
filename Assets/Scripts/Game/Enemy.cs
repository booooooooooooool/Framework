using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject OverUI;
    private void OnMouseDown()
    {
        new KillEnemyCommand()
            .Execute();
        Destroy(gameObject);
    }
}
