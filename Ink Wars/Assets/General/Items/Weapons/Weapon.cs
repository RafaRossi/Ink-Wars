using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Equipments, ITriggerable
{
    [Header("Weapon Properties")]
    [SerializeField] protected Transform weaponHandler;

    [SerializeField] protected WeaponAsset weapon => Profile.weapon;

    protected CharacterFire characterFire;

    protected override void Awake()
    {
        base.Awake();

        characterFire = GetComponentInParent<CharacterFire>();
    }

    protected override void OnEnable()
    {
        characterFire.Fire += Trigger;
    }

    protected override void OnDisable()
    {
        characterFire.Fire -= Trigger;
    }

    protected override void Initialize()
    {
        Instantiate(weapon.equipmentModel, transform.position, Quaternion.identity, characterFire.gameObject.transform);     
    }    
    public abstract void Trigger();
}
