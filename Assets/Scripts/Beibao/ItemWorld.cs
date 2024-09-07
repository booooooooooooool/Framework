using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    private Item item;
    private Transform SpawnObj;

    public static ItemWorld SpawnItemWorld(Vector3 position, Item item, Vector3 rotation)
    {
        Transform transform = Instantiate(item.GetPf(), position, Quaternion.Euler(rotation));

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.setItme(item);
        return itemWorld;
    }
    private void Awake()
    {

    }

    public void setItme(Item item)
    {
        this.item = item;
        SpawnObj = item.GetPf();
    }
    public Item GetItem()
    {
        return item;
    }
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
