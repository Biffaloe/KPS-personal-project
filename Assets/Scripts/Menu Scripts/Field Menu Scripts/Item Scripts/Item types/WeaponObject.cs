﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment/Weapon")]
public class WeaponObject : ItemObject
{
    public float atkBonus;
    public float magBonus;
    public float defBonus;
    public float mdfBonus;
    public float agiBonus;
    private void Awake()
    {
        type = ItemType.Weapon;
    }
}
