using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : CharacterEquipments
{
    protected override EquipmentAssets Equipment => Profile.hat;

    protected override void InitializeComponent()
    {
        base.InitializeComponent();

        Instantiate(Profile.hat.equipmentModel, transform.position, Quaternion.identity);
    }
}
