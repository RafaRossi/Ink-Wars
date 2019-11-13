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
    private Weapon weapon;

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
        List<GameObject> equipments = new List<GameObject>();

        equipments.Add(Instantiate(profile.hat.equipmentModel, hatHolder.position, hatHolder.rotation, hatHolder));
        equipments.Add(Instantiate(profile.clothes.equipmentModel, armorHolder.position, armorHolder.rotation, armorHolder));
        equipments.Add(Instantiate(profile.weapon.equipmentModel, weaponHolder.position, weaponHolder.rotation, weaponHolder));

        foreach (GameObject equipment in equipments)
        {
            equipment.GetComponent<Equipment>().OnInitializeRequest();
        }
    }
}
