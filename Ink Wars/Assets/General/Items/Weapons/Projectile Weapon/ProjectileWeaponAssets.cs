using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile Weapon", menuName = "Items/Weapon/Projectile Weapon")]
public class ProjectileWeaponAssets : WeaponAsset
{
    [Header("Weapon Properties")]
    public int totalAmmo;
    public int maxReloadedAmmo;
    public float timeToReload;
    public float timeBetweenShots;

    [Header("Weapon Projectile")]
    public ProjectileAsset projectile;

    public override void Initialize(GameObject obj)
    {
        ProjectileWeapon weapon = obj.AddComponent<ProjectileWeapon>();

        weapon.totalAmmo = totalAmmo;
        weapon.maxReloadedAmmo = maxReloadedAmmo;

        weapon.timeToReload = timeToReload;
        weapon.timeBetweenShots = timeBetweenShots;

        weapon.projectile = projectile;

        //projectile.Initialize(obj);
    }
}
