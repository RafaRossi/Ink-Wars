using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterBase))]
public class CharacterHealth : MonoBehaviour, IDamageable
{
    private CharacterBase character;

    [Header("Character Health")]
    private float maxHealth;
    private float CurrentHealth
    {
        get
        {
            return character.health.Value;
        }
        set
        {
            character.health.Value = value;
        }
    }

    private float ElementalResistance
    {
        get
        {
            return character.elementalResistance.Value;
        }
    }

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
    }

    private void OnEnable()
    {
        character.InitializeCharacter += InitializeHealth;
    }

    private void OnDisable()
    {
        character.InitializeCharacter -= InitializeHealth;
    }

    public void InitializeHealth(CharacterAsset character)
    {
        maxHealth = character.maxHealth;

        CurrentHealth = maxHealth;
    }

    public void Heal(float amount)
    {
        CurrentHealth += amount;
    }

    public void TakeDamage(int damage = 0, Elements element = null)
    {
        CurrentHealth -= damage - (damage * (character.defense.Value/100));

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, Mathf.Infinity);

    }

    public void Die()
    {

    }
}
