using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Shop Item", menuName = "Shop Item")]
public class ShopItem : ScriptableObject
{
    public ItemsAssets item;
    public ShopItemInfo info = new ShopItemInfo();
}

[System.Serializable]
public class ShopItemInfo
{
    public ShopCurrency currency;
    public float price;
}
