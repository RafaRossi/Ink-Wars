using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class CharacterHealth : CharacterComponent, IDamageable
{
    [SerializeField] private CharacterStat referenceStat;
    protected CharacterStats stats;
    private float maxHealth;
    private float CurrentHealth
    {
        get
        {
            return stats.value;
        }
        set
        {
            stats.value = value;
        }
    }

    private Action OnTakeDamage = delegate { };
    private Action OnCharacterDie = delegate { };

    public void Heal(float amount)
    {
        CurrentHealth += amount;
    }
    protected override void InitializeComponent()
    {
        stats = Profile.characterStats.FirstOrDefault(c => c.stat == referenceStat);
    }
    public void TakeDamage(int damage = 0)
    {
        /*CurrentHealth -= damage - (damage * (Profile.defense.value/100));

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, Mathf.Infinity);*/

        OnTakeDamage();
    }

    public void Die()
    {
        OnCharacterDie();
    }
}
