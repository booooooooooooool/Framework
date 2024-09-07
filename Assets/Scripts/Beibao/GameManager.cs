using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UI_Inventory ui_inventory;
    public Inventory inventory;
    public static GameManager instance;

    public Transform Beibao;
    private void Awake()
    {
        instance = this;
        inventory = new Inventory();
        ui_inventory.SetInventory(inventory);


    }
    private void Start()
    {
        Debug.Log(ItemAssets.instance.SwordSprite);
        ItemWorld.SpawnItemWorld(new Vector3(-1.5f, 0, 0), new Item
        {
            ID = 0,
            Name = "Sword",
            Type = Item.ItemType.Weapon,
            Quality = Item.ItemQuality.Common,
            Des1 = "’‚ «Ω£",
            Des2 = "≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ",
            Capacity = 1,
            BuyPrice = 100,
            SellPrice = 10
        }, new Vector3(90, 0, 90)
        );
        ItemWorld.SpawnItemWorld(new Vector3(-3f, 0, 0), new Item
        {
            ID = 1,
            Name = "Equipment",
            Type = Item.ItemType.Equipment,
            Quality = Item.ItemQuality.Common,
            Des1 = "’‚ «◊∞±∏",
            Des2 = "≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ",
            Capacity = 1,
            BuyPrice = 100,
            SellPrice = 10
        }
        , Vector3.zero
        );
        ItemWorld.SpawnItemWorld(new Vector3(-4.5f, 0, 0), new Item
        {
            ID = 2,
            Name = "HealdPotion",
            Type = Item.ItemType.Consumable,
            Quality = Item.ItemQuality.Common,
            Des1 = "’‚ «“©",
            Des2 = "≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ≤‚ ‘√Ë ˆ",
            Capacity = 1,
            BuyPrice = 100,
            SellPrice = 10
        }
        ,Vector3.zero
        );


        if (Beibao.gameObject.activeSelf)
            ui_inventory.RefreshInventoryItems();
    }
    public void AddItem(Item item)
    {
        inventory.AddItem(item);
        if(Beibao.gameObject.activeSelf)
            ui_inventory.RefreshInventoryItems();
    }
    public void RemoveItem(Item item)
    {
        inventory.RemoveItem(item);
        if (Beibao.gameObject.activeSelf)
            ui_inventory.RefreshInventoryItems();
    }
    public List<Item> GetItemList()
    {
        return inventory.GetItemsList();
    }
    public void toggle()
    {
        if (Beibao.gameObject.activeSelf)
        {
            Beibao.gameObject.SetActive(false);
        }
        else
        {
            Beibao.gameObject.SetActive(true);
            ui_inventory.RefreshInventoryItems();
        }
    }
    
}
