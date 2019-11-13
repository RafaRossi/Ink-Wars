using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : Equipment
{
    protected override EquipmentAssets EquipmentAsset => Profile.clothes;

    protected override void Initialize()
    {
        base.Initialize();
    }
}
