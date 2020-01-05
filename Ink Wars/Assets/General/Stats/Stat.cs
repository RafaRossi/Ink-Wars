using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stat : ScriptableObject
{
    public Sprite sprite;
}

[System.Serializable]
public class Stats<T> where T : Stat
{
    public T stat;
    public float value;
}

[System.Serializable]
public class CharacterStats : Stats<CharacterStat>
{

}

[System.Serializable]
public class WeaponStats : Stats<WeaponStat>
{

}
