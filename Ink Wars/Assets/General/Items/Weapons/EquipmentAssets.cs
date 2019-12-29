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

    public Action<CharacterProfile> OnEquip = delegate { };
    public Action<CharacterProfile> OnUnequip = delegate { };

    public override void Initialize(GameObject obj)
    {
        CharacterBase character = obj.GetComponent<CharacterBase>();

        if(character)
        {
            OnEquip(character.profile);
        }
    }

    private void OnEnable()
    {
        OnEquip += AddStats;
        OnUnequip += RemoveStats;
    }

    private void OnDisable()
    {
        OnEquip -= AddStats;
        OnUnequip -= RemoveStats;
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
