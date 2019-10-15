using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterAsset : ScriptableObject
{
    public string characterName;
    public string description;

    public float maxHealth;

    public float movementSpeed;
    public float turnSpeed;

    public float baseAttack;
    public float baseDefense;

    public GameObject characterModel;
}
