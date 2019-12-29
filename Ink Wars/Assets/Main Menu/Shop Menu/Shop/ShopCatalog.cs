using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Catalog", menuName = "Shop Catalog")]
public class ShopCatalog : ScriptableObject
{
    public List<ShopItem> items = new List<ShopItem>();
}
