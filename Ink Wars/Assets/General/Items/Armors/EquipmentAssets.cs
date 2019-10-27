using System;
using UnityEngine;

public abstract class EquipmentAssets : ItemsAssets
{
    [Header("Equipment Properties")]
    public GameObject equipmentModel;

    [Header("Modifiers")]
    public float speedModifierValue;
    public float healthModifierValue;
    public float attackModifierValue;
    public float defenseModifierValue;

    public Action<CharacterProfile> OnEquip => AddStats;
    public Action<CharacterProfile> OnUnequip => RemoveStats;

    public override void Initialize(GameObject obj)
    {
        CharacterEquipments character = obj.GetComponent<CharacterEquipments>();

        if(character)
        {
            OnEquip(character.Profile);
        }
    }

    public virtual void AddStats(CharacterProfile profile)
    {
        profile.attack += profile.attack.AddPercentage(attackModifierValue);
        profile.defense += profile.defense.AddPercentage(defenseModifierValue);
        profile.health += profile.health.AddPercentage(healthModifierValue);
        profile.speed += profile.speed.AddPercentage(speedModifierValue);
    }

    public virtual void RemoveStats(CharacterProfile profile)
    {
        profile.attack -= profile.attack.RemovePercentage(attackModifierValue);
        profile.defense -= profile.defense.RemovePercentage(defenseModifierValue);
        profile.health -= profile.health.RemovePercentage(healthModifierValue);
        profile.speed -= profile.speed.RemovePercentage(speedModifierValue);
    }
}
