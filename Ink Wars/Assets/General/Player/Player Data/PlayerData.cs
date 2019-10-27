using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Player Data", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    public CharacterAsset character;
    
    public WeaponAsset weapon;

    public HatAssets hat;
    public ClothesAssets clothes;
 
    public List<ItemsAssets> items = new List<ItemsAssets>();

    public Action OnInitialize = delegate { };

    public GameObject CurrentCharacterObject
    {
        get; set;
    }

    public void Initialize(GameObject obj)
    {
        CurrentCharacterObject = obj;

        OnInitialize();
    }
}
