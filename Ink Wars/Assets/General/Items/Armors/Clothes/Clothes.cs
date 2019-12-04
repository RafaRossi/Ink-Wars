using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : Equipment
{
    public override EquipmentAssets EquipmentAsset => Profile.clothes;

    protected override void Initialize()
    {
        base.Initialize();
    }
}
