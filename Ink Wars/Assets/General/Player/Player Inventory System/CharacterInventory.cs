using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : CharacterComponent
{
    public int maxInventoryCapacity;

    public List<ItemsAssets> items = new List<ItemsAssets>();

    public Action OnInventoryUpdate = delegate { };
    public bool CanAddItem => items.Count < maxInventoryCapacity;

    public bool AddItem(ItemsAssets item)
    {
        if(CanAddItem)
        {
            items.Add(item);

            OnInventoryUpdate();

            return true;
        }

        else Debug.Log("Full Inventory");
        return false;
    }

    public void RemoveItem(ItemsAssets item)
    {
        if(items.Contains(item))
        {
            items.Remove(item);
            
            OnInventoryUpdate();
        }
        else Debug.Log("Item not Found");
    }

    protected override void InitializeComponent()
    {
        items = Profile.items;
    }
}