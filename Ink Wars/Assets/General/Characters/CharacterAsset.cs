using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterAsset : ScriptableObject
{
    [SerializeField] private string characterName = "";
    [SerializeField] private string description = "";

    [SerializeField] private float maxHealth = 0;

    [SerializeField] private float movementSpeed = 0;
    [SerializeField] private float turnSpeed = 0;

    [SerializeField] private float baseAttack = 0;
    [SerializeField] private float baseDefense = 0;

    [SerializeField] private GameObject characterModel = null;

    public string CharacterName { get => characterName; }
    public string Description { get => description; }
    public float MaxHealth { get => maxHealth; }
    public float MovementSpeed { get => movementSpeed; }
    public float TurnSpeed { get => turnSpeed; }
    public float BaseAttack { get => baseAttack; }
    public float BaseDefense { get => baseDefense; }
    public GameObject CharacterModel { get => characterModel; }
}
