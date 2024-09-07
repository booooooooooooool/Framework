using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int ID { get; set; }                 //ID
    public string Name { get; set; }            //名字
    public ItemType Type { get; set; }      //类型
    public ItemQuality Quality { get; set; }        //品质
    public string Des1 { get; set; }     //描述1
    public string Des2 { get; set; }     //描述1
    public int Capacity { get; set; }           //容量
    public int BuyPrice { get; set; }           //购买价格
    public int SellPrice { get; set; }          //出售价格


    /// <summary>
    /// 物品类型
    /// </summary>
    public enum ItemType
    {
        Consumable,     //消耗品
        Equipment,      //装备
        Weapon,         //武器
        Material        //材料
    }

    /// <summary>
    /// 品质
    /// </summary>
    public enum ItemQuality
    {
        Common,     //一般
        Rare,       //稀有
        Epic,       //史诗
        Legendary,  //传说
    }

    public Sprite GetSprite()
    {
        switch (Type)
        {
            case ItemType.Weapon: return ItemAssets.instance.SwordSprite;
            case ItemType.Equipment: return ItemAssets.instance.EquipmentSprite;
            case ItemType.Consumable: return ItemAssets.instance.HealdPotion;
            default: return null;
        }
    }
    public Transform GetPf()
    {
        switch (Type)
        {
            case ItemType.Weapon: return ItemAssets.instance.pfSword;
            case ItemType.Equipment: return ItemAssets.instance.pfEquipmentSprite;
            case ItemType.Consumable: return ItemAssets.instance.pfHealdPotion;
            default: return null;
        }
    }



    //public Item(int id, string name, ItemType itemType, ItemQuality quality, string description, int capacity, int buyPrice, int sellPrice)
    //{
    //    this.ID = id;
    //    this.Name = name;
    //    this.Type = itemType;
    //    this.Quality = quality;
    //    this.Des1 = description;
    //    this.Capacity = capacity;
    //    this.BuyPrice = buyPrice;
    //    this.SellPrice = sellPrice;
//}

}
