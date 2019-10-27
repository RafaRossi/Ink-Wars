using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [SerializeField] private ProjectileAsset projectile;

    [HideInInspector] public float BaseDamage { get; set; }
    [HideInInspector] public float Mass
    {
        get
        {
            return rb.mass;
        }

        set
        {
            rb.mass = value;
        }
    }

    [HideInInspector] public GameObject ProjectileImapctParticles { get; set; }

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Initialize()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
