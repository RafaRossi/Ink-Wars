using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Modifiers : ItemsAssets
{

}

[System.Serializable]
public class StatModifierBase<T> where T : Stat
{
    public T stat;
    public float value;
}