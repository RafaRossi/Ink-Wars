using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : CharacterComponent, IDamageable
{
    private float maxHealth;
    private float CurrentHealth
    {
        get
        {
            return Profile.health;
        }
        set
        {
            Profile.health = value;
        }
    }

    protected override void InitializeComponent()
    {
        maxHealth = Profile.health;
    }

    public void Heal(float amount)
    {
        CurrentHealth += amount;
    }

    public void TakeDamage(int damage = 0)
    {
        CurrentHealth -= damage - (damage * (Profile.defense/100));

        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, Mathf.Infinity);
    }

    public void Die()
    {

    }
}
