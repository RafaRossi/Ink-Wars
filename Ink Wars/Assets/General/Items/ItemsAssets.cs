using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemsAssets : ScriptableObject
{
    [Header("Item Infos")]
    public string itemName;
    public string description;
    public Sprite itemImg;
    public abstract void Initialize(GameObject obj);
}