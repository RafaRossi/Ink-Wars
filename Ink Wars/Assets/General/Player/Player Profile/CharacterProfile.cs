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
        hat = player.hat;
        clothes = player.clothes;

        items = player.items;
    }

    public float speed;
    public float health;
    public float attack;
    public float defense;

    public WeaponAsset weapon;
    public HatAssets hat;
    public ClothesAssets clothes;
    public List<ItemsAssets> items;
}
