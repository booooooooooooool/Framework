using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets instance;
    private void Awake()
    {
        instance = this;
    }

    public Transform pfSword;
    public Transform pfHealdPotion;
    public Transform pfEquipmentSprite;

    public Sprite SwordSprite;
    public Sprite EquipmentSprite;
    public Sprite HealdPotion;
}
