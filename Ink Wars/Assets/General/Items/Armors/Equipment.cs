using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterBase))]
public abstract class Equipment : MonoBehaviour
{
    [SerializeField] protected EquipmentAssets equipment;

    protected CharacterBase character;

    public event Action OnEquiped;
    public event Action OnRemoved;

    protected virtual void Awake()
    {
        character = GetComponentInParent<CharacterBase>();
    }

    public abstract void Initialize();
}
