using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : CharacterEquipments
{
    protected override EquipmentAssets Equipment => Profile.clothes;

    protected override void InitializeComponent()
    {
        base.InitializeComponent();

        Instantiate(Profile.clothes.equipmentModel, transform.position, Quaternion.identity);
    }
}
