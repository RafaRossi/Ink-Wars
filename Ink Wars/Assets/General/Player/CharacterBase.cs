using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public CharacterAsset Character { get; set; }

    public FloatVariable speed;
    public FloatVariable health;
    public FloatVariable defense;
    public FloatVariable attack;

    public FloatVariable elementalResistance;

    public Action<CharacterAsset> InitializeCharacter = delegate { };

    private void Start()
    {
        InitializeCharacter(Character);
    }
}
