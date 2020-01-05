using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : Weapon
{
    [HideInInspector] [Min(0)] public int totalAmmo = 0;

    [HideInInspector] [Min(0)] public int maxReloadedAmmo = 0;
    [HideInInspector] [Min(0)] public int currentAmmo = 0;

    [HideInInspector] [Min(0)] public float timeToReload = 0;

    [HideInInspector] [Min(0)] public float timeBetweenShots = 0;

    [HideInInspector] [Min(0)] public int ammoPerShot = 0;

    [HideInInspector] public ProjectileAsset projectile;

    private float lastShotTime = 0;

    public override bool CanShoot { get { return HasAmmo() && !IsCoolDown(); } }

    protected override void Initialize()
    {   
        currentAmmo = maxReloadedAmmo;
    }

    public override void Trigger()
    {
         if(!CanShoot)
            return;

        OnTriggerRequest();

        currentAmmo -= ammoPerShot;
    }

    private bool IsCoolDown()
    {
        if (Time.time - lastShotTime < timeBetweenShots)
            return true;

        lastShotTime = Time.time;
        return false;
    }

    private bool HasAmmo()
    {
        if (currentAmmo >= ammoPerShot)
        {
            return true;
        }
        else if(totalAmmo > ammoPerShot)
        {
            StartCoroutine(Reload(timeToReload));
        }
        return false;
    }

    IEnumerator Reload(float time)
    {
        yield return new WaitForSeconds(time);

        totalAmmo -= maxReloadedAmmo;
        currentAmmo = maxReloadedAmmo;
    }
}
