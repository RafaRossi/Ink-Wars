﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : Weapon
{
    [HideInInspector] [Min(0)] public int totalAmmo = 0;

    [HideInInspector] [Min(0)] public int maxAmmo = 0;
    [HideInInspector] [Min(0)] public int currentAmmo = 0;

    [HideInInspector] [Min(0)] public float timeToReload = 0;

    [HideInInspector] [Min(0)] public float timeBetweenShots = 0;

    [HideInInspector] [Min(0)] public float shootForce = 0;

    private float lastShotTime = 0;

    private bool CanShoot { get { return HasAmmo() && !IsCoolDown(); } }

    private ProjectileWeaponAssets projectileWeaponAsset;

    protected override void Initialize()
    {
        base.Initialize();
        
        projectileWeaponAsset = EquipmentAsset as ProjectileWeaponAssets;

        totalAmmo = projectileWeaponAsset.totalAmmo;
        maxAmmo = projectileWeaponAsset.maxAmmo;
        currentAmmo = maxAmmo;

        timeToReload = projectileWeaponAsset.timeToReload;
        timeBetweenShots = projectileWeaponAsset.timeBetweenShots;

        shootForce = projectileWeaponAsset.shootForce;
    }

    public override void Trigger()
    {
        if (CanShoot)
        {
            var projectile = Instantiate(projectileWeaponAsset.projectile.projectilePrefab, weaponHandler.position, Quaternion.identity);

            projectile.GetComponent<Rigidbody>().AddForce(weaponHandler.transform.forward * projectileWeaponAsset.shootForce);

            currentAmmo -= 1;
        }       
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
        if (currentAmmo > 0)
        {
            return true;
        }
        else if(totalAmmo > 0)
        {
            StartCoroutine(Reload(timeToReload));
        }
        return false;
    }

    IEnumerator Reload(float time)
    {
        yield return new WaitForSeconds(time);

        totalAmmo -= maxAmmo;
        currentAmmo = maxAmmo;
    }
}
