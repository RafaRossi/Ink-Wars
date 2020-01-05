using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterProfile
{
    public CharacterProfile(PlayerData player)
    {
        characterStats = new List<CharacterStats>();

        foreach (CharacterStats stat in player.character.characterStats)
        {
            characterStats.Add(new CharacterStats { stat = stat.stat, value = stat.value} );
        }

        prefab = player.character.CharacterPrefab;
        weapon = player.weapon;
        items = player.items;
    }
    
    public List<CharacterStats> characterStats;
    public WeaponAsset weapon;
    public List<ItemsAssets> items;
    public GameObject prefab;
}
