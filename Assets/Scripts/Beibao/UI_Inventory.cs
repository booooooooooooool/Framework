using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    public Transform[] icon;
    private void Awake()
    {
        icon = new Transform[32];
        for (int i = 0; i < icon.Length; i++)
        {
            icon[i] = transform.GetChild(i).Find("Obj/icon");
        }
        
    }
    private void Start()
    {

    }
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }
    public void RefreshInventoryItems()
    {
        List<Item> items = inventory.GetItemsList();
        for (int i = 0; i < items.Count; i++)
        {
            switch (items[i].Type)
            {
                case Item.ItemType.Weapon:
                    icon[i].GetComponent<Image>().sprite = items[i].GetSprite();
                    break;
                case Item.ItemType.Equipment:
                    icon[i].GetComponent<Image>().sprite = items[i].GetSprite();
                    break;
                case Item.ItemType.Consumable:
                    icon[i].GetComponent<Image>().sprite = items[i].GetSprite();
                    break;
                default: return;
            }
        }
    }

}
