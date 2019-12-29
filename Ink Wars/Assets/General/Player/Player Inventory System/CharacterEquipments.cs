using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEquipments : CharacterComponent
{
    public WeaponAsset Weapon { get => Profile.weapon; }

    protected override void Awake()
    {
        character = GetComponentInParent<CharacterBase>();
    }
    
    protected override void InitializeComponent()
    {
        Weapon.Initialize(gameObject);
    }
}
