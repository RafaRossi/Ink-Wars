using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class CharacterAsset : ScriptableObject
{
    [SerializeField] private string characterName = "";
    public string CharacterName { get => characterName; }

    [SerializeField] private string description = "";
    public string Description { get => description; }

    [SerializeField] private GameObject characterPrefab = null;
    public GameObject CharacterPrefab { get => characterPrefab; }

    public List<CharacterStats> characterStats = new List<CharacterStats>();
}
