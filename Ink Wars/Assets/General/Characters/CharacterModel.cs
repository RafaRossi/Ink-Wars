using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    public Transform hatHolder;
    public Transform armorHolder;
    public Transform weaponHolder;

    public System.Action<CharacterProfile> Initialize;

    private CharacterBase character;

    private void Awake()
    {
        character = GetComponentInParent<CharacterBase>();
    }

    private void OnEnable()
    {
        Initialize += InitializeModels;
    }

    private void OnDisable()
    {
        Initialize -= InitializeModels;
    }

    private void InitializeModels(CharacterProfile profile)
    {
        Instantiate(profile.hat.equipmentModel, hatHolder.position, hatHolder.rotation, hatHolder);
        Instantiate(profile.clothes.equipmentModel, armorHolder.position, armorHolder.rotation, armorHolder);
        Instantiate(profile.weapon.equipmentModel, weaponHolder.position, weaponHolder.rotation, weaponHolder);
    }
}
