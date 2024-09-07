using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int ID { get; set; }                 //ID
    public string Name { get; set; }            //����
    public ItemType Type { get; set; }      //����
    public ItemQuality Quality { get; set; }        //Ʒ��
    public string Des1 { get; set; }     //����1
    public string Des2 { get; set; }     //����1
    public int Capacity { get; set; }           //����
    public int BuyPrice { get; set; }           //����۸�
    public int SellPrice { get; set; }          //���ۼ۸�


    /// <summary>
    /// ��Ʒ����
    /// </summary>
    public enum ItemType
    {
        Consumable,     //����Ʒ
        Equipment,      //װ��
        Weapon,         //����
        Material        //����
    }

    /// <summary>
    /// Ʒ��
    /// </summary>
    public enum ItemQuality
    {
        Common,     //һ��
        Rare,       //ϡ��
        Epic,       //ʷʫ
        Legendary,  //��˵
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
