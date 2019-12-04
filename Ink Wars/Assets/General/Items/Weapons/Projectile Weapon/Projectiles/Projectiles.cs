using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectiles : MonoBehaviour
{
    [SerializeField] private ProjectileAsset projectile;

    private float BaseDamage { get; set; }
    private float MovementSpeed { get; set; }

    private float Mass
    {
        get
        {
            return Rigidbody.mass;
        }
        set
        {
            Rigidbody.mass = value;
        }
    }
    private bool UseGravity
    {
        get
        {
            return Rigidbody.useGravity;
        }
        set
        {
            Rigidbody.useGravity = value;
        }
    }
    [HideInInspector] public GameObject ProjectileImpactParticles { get; set; }

    private Rigidbody rb = null;
    private Rigidbody Rigidbody
    {
        get
        {
            if(rb == null)
            {
                rb = GetComponent<Rigidbody>();
            }

            return rb;
        }
    }

    private event Action OnProjectileHit;
    private event Action OnProjectileInstantiate;

    public void Initialize(ProjectileAsset asset)
    {
        projectile = asset;

        BaseDamage = asset.baseDamage;
        MovementSpeed = asset.movementSpeed;

        Mass = asset.mass;
        UseGravity = asset.useGravity;

        ProjectileImpactParticles = asset.projectileImpactParticles;

        OnProjectileInstantiate();
    }

    private void OnEnable()
    {
        OnProjectileHit += ProjectileHit;

        OnProjectileInstantiate += Move;
    }

    private void OnDisable()
    {
        OnProjectileHit -= ProjectileHit;

        OnProjectileInstantiate -= Move;
    }

    private void Move()
    {
        Rigidbody.AddForce(transform.forward * MovementSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnProjectileHit();
    }

    private void ProjectileHit()
    {
        //Instantiate(ProjectileImapctParticles, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
