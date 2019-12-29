using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Player Data", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    public CharacterAsset character;
    
    public WeaponAsset weapon;
 
    public List<ItemsAssets> items = new List<ItemsAssets>();
}
