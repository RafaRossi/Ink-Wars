using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public PlayerData player;

    public CharacterProfile profile;
    
    public Action InitializeCharacter = delegate { };

    private void Awake()
    {
        profile = new CharacterProfile(player);
    }

    private void OnEnable()
    {
        InitializeCharacter += Initialize;
    }

    private void OnDisable()
    {
        InitializeCharacter -= Initialize;
    }

    private void Initialize()
    {
        player.Initialize(gameObject);
    }

    private void Start()
    {
        InitializeCharacter();
    }
}
