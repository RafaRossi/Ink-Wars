using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserWeapon : Weapon
{
    private float maxLaserRange = 0;

    private float timeBetweenShots = 0;


    public override bool CanShoot { get; }

    protected override void Initialize()
    {

    }

    public override void Trigger()
    {
        
    }
}
