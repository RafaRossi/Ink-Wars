using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Equipment, ITriggerable
{
    public Action OnTriggerRequest = delegate { };

    public override EquipmentAssets EquipmentAsset => Profile.weapon;

    protected CharacterFire characterFire;

    public abstract bool CanShoot { get; }

    protected override void Awake()
    {
        base.Awake();

        characterFire = GetComponentInParent<CharacterFire>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        characterFire.Fire += Trigger;
    }

    protected override void OnDisable()
    {
        base.OnDisable();

        characterFire.Fire -= Trigger;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }    

    public abstract void Trigger();
}
