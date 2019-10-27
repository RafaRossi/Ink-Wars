using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : CharacterEquipments, ITriggerable
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
        base.OnEnable();

        characterFire.Fire += Trigger;
    }

    protected override void OnDisable()
    {
        base.OnEnable();

        characterFire.Fire -= Trigger;
    }

    protected override void InitializeComponent()
    {
        base.InitializeComponent();

        Instantiate(weapon.equipmentModel, transform.position, Quaternion.identity);
    }    
    public abstract void Trigger();
}
