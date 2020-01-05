using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, ITriggerable
{
    public Action OnTriggerRequest = delegate { };

    protected CharacterFire characterFire;

    public abstract bool CanShoot { get; }

    protected void Awake()
    {
        characterFire = GetComponentInParent<CharacterFire>();
    }

    protected void OnEnable()
    {
        characterFire.Fire += Trigger;
    }

    protected void OnDisable()
    {
        characterFire.Fire -= Trigger;
    }

    protected abstract void Initialize();
    public abstract void Trigger();
}
