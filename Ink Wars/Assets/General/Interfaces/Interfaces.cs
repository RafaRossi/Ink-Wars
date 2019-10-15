using System;

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
    void TakeDamage(int damage = 0, Elements element = null);
}
