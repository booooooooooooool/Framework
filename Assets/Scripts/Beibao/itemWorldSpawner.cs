using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemWorldSpawner : MonoBehaviour
{
    public Item item;

    private void Awake()
    {
        ItemWorld.SpawnItemWorld(transform.position, item, transform.rotation.eulerAngles);
    }
}
