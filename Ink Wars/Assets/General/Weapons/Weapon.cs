using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, ITriggerable
{
    [Header("Weapon Properties")]
    [SerializeField] protected Transform weaponHandler;

    [SerializeField] protected WeaponAsset weapon;

    protected CharacterFire character;

    private void Awake()
    {
        character = GetComponentInParent<CharacterFire>();
    }

    private void OnEnable()
    {
        character.Fire += Trigger;
    }

    private void OnDisable()
    {
        character.Fire -= Trigger;
    }

    private void Start()
    {
        weapon.Initialize(gameObject);
    }

    public abstract void Initialize();
    public abstract void Trigger();
}
