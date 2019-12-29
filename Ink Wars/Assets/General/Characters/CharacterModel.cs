using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
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
        Instantiate(profile.weapon.equipmentModel, weaponHolder.position, weaponHolder.rotation, weaponHolder);
    }
}
