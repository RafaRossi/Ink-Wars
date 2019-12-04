using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : Equipment
{
    public override EquipmentAssets EquipmentAsset => Profile.hat;

    protected override void Initialize()
    {
        base.Initialize();
    }
}
