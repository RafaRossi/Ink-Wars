using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public PlayerData player;

    public CharacterProfile profile;

    private CharacterModel model;
    
    public Action InitializeCharacter = delegate { };

    private void Awake()
    {
        profile = new CharacterProfile(player);
    }

    private void OnEnable() 
    {
        InitializeCharacter += InstantiateCharacter;
    }
    private void OnDisable()
    {
        InitializeCharacter -= InstantiateCharacter;
    }

    private void Start()
    {
        InitializeCharacter();
    }

    public void InstantiateCharacter()
    {
        model = Instantiate(profile.prefab, transform.position, Quaternion.identity, transform).GetComponent<CharacterModel>();

        model.Initialize(profile);
    }
}