using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour, ITriggerable
{
    public Transform weaponHandler;

    private Weapon weapon;

    void ITriggerable.Trigger()
    {

    }
}
