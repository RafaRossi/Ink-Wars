using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponHandler : MonoBehaviour
{
    [SerializeField] private Weapon weapon;
    protected Weapon Weapon
    {
        get
        {
            if(!weapon)
            {
                weapon = GetComponentInParent<Weapon>();
            }
            return weapon;
        }
    }

    private void OnEnable() 
    {
        Weapon.OnTriggerRequest += OnFireRequest;
    }

    private void OnDisable() 
    {
        Weapon.OnTriggerRequest -= OnFireRequest;
    }

    protected abstract void OnInitialize();
    protected abstract void OnFireRequest();
}
