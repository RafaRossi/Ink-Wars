using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(CharacterBase))]
public abstract class CharacterComponent : MonoBehaviour
{    
    protected CharacterBase character;
    public CharacterProfile Profile => character.profile;

    protected virtual void Awake()
    {
        character = GetComponent<CharacterBase>();
    }
    protected virtual void OnEnable()
    {
        character.InitializeCharacter += InitializeComponent;
    }

    protected virtual void OnDisable()
    {
        character.InitializeCharacter -= InitializeComponent;
    }

    protected abstract void InitializeComponent();
}
