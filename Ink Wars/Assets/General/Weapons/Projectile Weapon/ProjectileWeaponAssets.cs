using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile Weapon", menuName = "Weapon/Projectile Weapon")]
public class ProjectileWeaponAssets : WeaponAsset
{
    [Header("Weapon Properties")]
    public int totalAmmo;
    public int maxAmmo;

    public float timeToReload;

    public float timeBetweenShots;

    public float shootForce;

    [Header("Weapon Projectile")]
    public ProjectileAsset projectile;

    public override void Initialize(GameObject weapon)
    {
        ProjectileWeapon projectileWeapon = weapon.GetComponent<ProjectileWeapon>();

        projectileWeapon.totalAmmo = totalAmmo;
        projectileWeapon.maxAmmo = maxAmmo;
        projectileWeapon.currentAmmo = maxAmmo;

        projectileWeapon.timeToReload = timeToReload;
        projectileWeapon.timeBetweenShots = timeBetweenShots;

        projectileWeapon.shootForce = shootForce;

        projectileWeapon.Initialize();
    }
}
