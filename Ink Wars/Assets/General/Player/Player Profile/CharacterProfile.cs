using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterProfile
{
    public CharacterProfile(PlayerData player)
    {
        speed = player.character.MovementSpeed;
        health = player.character.MaxHealth;
        attack = player.character.BaseAttack;
        defense = player.character.BaseDefense;

        weapon = player.weapon;
        items = player.items;

        prefab = player.character.CharacterPrefab;
    }

    public float speed;
    public float health;
    public float attack;
    public float defense;

    public WeaponAsset weapon;
    public List<ItemsAssets> items;

    public GameObject prefab;
}
