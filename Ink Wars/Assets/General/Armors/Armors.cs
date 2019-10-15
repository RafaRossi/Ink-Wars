using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterBase))]
public abstract class Armors : MonoBehaviour
{
    [SerializeField] protected ArmorsAssets armor;

    private CharacterBase character;

    public event Action OnArmorEquiped;
    public event Action OnArmorRemoved;

    public abstract void Initialize();
}
