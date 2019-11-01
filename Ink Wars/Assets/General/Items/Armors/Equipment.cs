using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterBase))]
public abstract class Equipments : MonoBehaviour
{
    protected virtual EquipmentAssets Equipment { get; set; }

    protected CharacterBase character;
    protected CharacterProfile Profile
    {
        get
        {
            return character.profile;
        }
    }

    public event Action OnEquiped;
    public event Action OnRemoved;

    protected virtual void Awake()
    {
        character = GetComponentInParent<CharacterBase>();
    }

    protected virtual void Initialize()
    {
        Instantiate(Equipment.equipmentModel, transform.position, Quaternion.identity);
    }

    protected abstract void OnEnable();
    protected abstract void OnDisable();
}
