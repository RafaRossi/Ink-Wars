using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterBase))]
public class CharacterFire : MonoBehaviour
{
    private CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
    }

    protected virtual void Fire()
    {
                  
    }
}
