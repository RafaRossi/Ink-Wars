using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Projectile", menuName = "Projectile")]
public class ProjectileAsset : ItemsAssets
{
    [Header("Projectile Properties")]
    public float baseDamage;
    public float movementSpeed;

    public float mass;
    public bool useGravity;

    [Header("Projectile Prefabs")]
    public GameObject projectilePrefab;

    public GameObject projectileImpactParticles;

    public override void Initialize(GameObject obj)
    {
        
    }
}
