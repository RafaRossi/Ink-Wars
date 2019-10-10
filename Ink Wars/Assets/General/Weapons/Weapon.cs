using UnityEngine;

public abstract class Weapon : ScriptableObject, ITriggerable
{
    public string weaponName;

    public int totalAmmo;
    public int maxAmmo;
    public int currentAmmo;

    public float timeToReload;

    public float timeBetweenShots;

    public float shootForce;

    public abstract void Initialize(GameObject gameObject);
    public abstract void Trigger();
}
