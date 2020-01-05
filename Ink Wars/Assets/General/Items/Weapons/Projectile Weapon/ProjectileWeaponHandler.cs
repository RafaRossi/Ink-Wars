using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponHandler : WeaponHandler<ProjectileWeapon>
{
    protected override void OnFireRequest()
    {
        Projectiles projectile = Instantiate(Weapon.projectile.projectilePrefab, transform.position, transform.rotation).GetComponent<Projectiles>();
            
        projectile.Initialize((Weapon.projectile));
    }

    protected override void OnInitialize()
    {
        
    }
}
