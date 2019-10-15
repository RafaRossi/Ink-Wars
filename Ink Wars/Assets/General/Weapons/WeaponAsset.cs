using UnityEngine;

public abstract class WeaponAsset : ScriptableObject
{
    [Header("Weapon Infos")]
    public string weaponName;
    public string weaponDescription;

    [Header("Weapon Elements")]
    public Elements element;

    [Header("Weapon Prefabs")]
    public GameObject weaponModel;

    public abstract void Initialize(GameObject weapon);
}
