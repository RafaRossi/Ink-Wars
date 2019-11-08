using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    protected abstract void Initialize();

    protected abstract void OnEnable();
    protected abstract void OnDisable();
}
