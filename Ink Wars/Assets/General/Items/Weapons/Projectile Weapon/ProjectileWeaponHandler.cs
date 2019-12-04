using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponHandler : WeaponHandler
{
    protected override void OnFireRequest()
    {
        Projectiles projectile = Instantiate((Weapon.EquipmentAsset as ProjectileWeaponAssets).projectile.projectilePrefab, transform.position, transform.rotation).GetComponent<Projectiles>();
            
        projectile.Initialize((Weapon.EquipmentAsset as ProjectileWeaponAssets).projectile);
    }

    protected override void OnInitialize()
    {
        
    }
}
