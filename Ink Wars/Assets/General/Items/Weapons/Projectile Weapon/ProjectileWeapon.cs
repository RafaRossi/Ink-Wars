using System;
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

    private ProjectileWeaponAssets projectileWeapon;

    protected override void InitializeComponent()
    {
        base.InitializeComponent();

        projectileWeapon = weapon as ProjectileWeaponAssets;

        totalAmmo = projectileWeapon.totalAmmo;
        maxAmmo = projectileWeapon.maxAmmo;
        currentAmmo = maxAmmo;

        timeToReload = projectileWeapon.timeToReload;
        timeBetweenShots = projectileWeapon.timeBetweenShots;

        shootForce = projectileWeapon.shootForce;
    }

    public override void Trigger()
    {
        if (CanShoot)
        {
            var projectile = Instantiate(projectileWeapon.projectile.projectilePrefab, weaponHandler.position, Quaternion.identity);

            projectile.GetComponent<Rigidbody>().AddForce(weaponHandler.transform.forward * projectileWeapon.shootForce);

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
