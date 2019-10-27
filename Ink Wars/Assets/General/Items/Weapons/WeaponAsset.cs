using UnityEngine;

public abstract class WeaponAsset : EquipmentAssets
{
    public override void Initialize(GameObject obj)
    {
        CharacterComponent character = obj.GetComponent<CharacterComponent>();
        OnEquip(character.Profile);

        character.Profile.weapon = this;
    }
}
