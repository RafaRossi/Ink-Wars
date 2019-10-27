using System;
using UnityEngine;

public interface IActivable
{
    void Activate();
}

public interface ITriggerable
{
    void Trigger();
}

public interface IDamageable
{
    void TakeDamage(int damage = 0);
}

public interface IEquipable
{
    void Equip(GameObject equiper);

    void Unequip(GameObject equiper);
}
