using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Projectile", menuName = "Projectile")]
public class ProjectileAsset : ScriptableObject
{
    [Header("Projectile Infos")]
    public string projectileName;
    public string description;

    [Header("Projectile Properties")]
    public float baseDamage;
    public float mass;

    [Header("Projectile Prefabs")]
    public GameObject projectilePrefab;

    public GameObject projectileImpactParticles;

    [Header("Projectile Element")]
    public Elements element;

    public void Initialize(GameObject obj)
    {
        Projectiles projectile = obj.GetComponent<Projectiles>();

        projectile.BaseDamage = baseDamage;
        projectile.Mass = mass;

        projectile.Element = element;

        projectile.ProjectileImapctParticles = projectileImpactParticles;

        projectile.Initialize();
    }
}
