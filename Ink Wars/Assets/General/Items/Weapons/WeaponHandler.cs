using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponHandler<T> : MonoBehaviour where T : Weapon
{
    private T weapon;
    protected T Weapon
    {
        get
        {
            if(!weapon)
            {
                weapon = GetComponentInParent<T>();
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
