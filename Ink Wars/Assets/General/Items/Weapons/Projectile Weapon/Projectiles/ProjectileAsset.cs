using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Projectile", menuName = "Projectile")]
public class ProjectileAsset : ItemsAssets
{
    [Header("Projectile Properties")]
    public float baseDamage;
    public float mass;

    [Header("Projectile Prefabs")]
    public GameObject projectilePrefab;

    public GameObject projectileImpactParticles;

    public override void Initialize(GameObject obj)
    {
        Projectiles projectile = obj.GetComponent<Projectiles>();

        projectile.BaseDamage = baseDamage;
        projectile.Mass = mass;

        projectile.ProjectileImapctParticles = projectileImpactParticles;

        projectile.Initialize();
    }
}
