using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class ProjectileAsset : ItemsAssets
{
    [Header("Projectile Properties")]
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
