using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterEquipments : CharacterComponent
{
    protected CharacterInventory inventory;

    protected virtual EquipmentAssets Equipment { get; set; }

    protected override void Awake()
    {
        character = GetComponentInParent<CharacterBase>();

        inventory = GetComponentInParent<CharacterInventory>();
    }
    
    protected override void InitializeComponent()
    {
        if(Equipment)
        {
            Equipment.Initialize(gameObject);
        }
    }
}
