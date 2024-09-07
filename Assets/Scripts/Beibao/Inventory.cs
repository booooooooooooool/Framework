using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    List<Item> itemlist;

    public Inventory()
    {
        itemlist = new List<Item>();
        AddItem(new Item
        {
            ID = 0,
            Name = "Sword",
            Type = Item.ItemType.Weapon,
            Quality = Item.ItemQuality.Common,
            Des1 = "ฒโสิร่ส๖",
            Des2 = "ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖",
            Capacity = 1,
            BuyPrice = 100,
            SellPrice = 10
        });
        AddItem(new Item
        {
            ID = 0,
            Name = "HealdPotion",
            Type = Item.ItemType.Consumable,
            Quality = Item.ItemQuality.Common,
            Des1 = "ฒโสิร่ส๖",
            Des2 = "ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖",
            Capacity = 1,
            BuyPrice = 10,
            SellPrice = 1
        });
        AddItem(new Item
        {
            ID = 0,
            Name = "Equipment",
            Type = Item.ItemType.Equipment,
            Quality = Item.ItemQuality.Common,
            Des1 = "ฒโสิร่ส๖",
            Des2 = "ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖ฒโสิร่ส๖",
            Capacity = 1,
            BuyPrice = 200,
            SellPrice = 20
        });
    }


    public void AddItem(Item item)
    {
        itemlist.Add(item);
        
    }
    public void RemoveItem(Item item)
    {
        itemlist.Remove(item);
    }
    public List<Item> GetItemsList()
    {
        return itemlist;
    }
}
