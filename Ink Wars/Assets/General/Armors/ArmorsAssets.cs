using UnityEngine;

public abstract class ArmorsAssets : ScriptableObject
{
    [Header("Armor Info")]
    public string armorName;
    public string description;

    [Header("Armor Properties")]
    public GameObject armorModel;

    [Header("Armor Element")]
    public Elements element;

    public abstract void Initialize(GameObject obj);
}
