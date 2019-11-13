using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : MonoBehaviour
{
    protected virtual EquipmentAssets EquipmentAsset { get; set; }

    protected CharacterBase character;
    protected CharacterProfile Profile
    {
        get
        {
            return character.profile;
        }
    }

    public Action OnInitializeRequest;

    public event Action OnEquiped;
    public event Action OnRemoved;

    protected virtual void Awake()
    {
        character = GetComponentInParent<CharacterBase>();
    }

    protected virtual void Initialize()
    {
        
    }

    protected virtual void OnEnable()
    {
        OnInitializeRequest += Initialize;
    }

    protected virtual void OnDisable()
    {
        OnInitializeRequest -= Initialize;
    }
}
