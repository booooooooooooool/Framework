using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ItemWorld itemworld = other.GetComponent<ItemWorld>();
        if (itemworld != null )
        {
            GameManager.instance.AddItem(itemworld.GetItem());
            itemworld.DestroySelf();
        }
    }
}
