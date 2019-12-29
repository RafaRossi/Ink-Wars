using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MenuBaseClass
{
    [SerializeField] private ShopTab currentSelectedTab;
    [SerializeField] private GameObject shopMenuContent;
    [SerializeField] private ShopButton button;

    protected override void Awake() 
    {
        base.Awake();
        
        OnMenuLoaded += () => currentSelectedTab.LoadTab();
    }

    public void LoadCatalog(ShopTab shopTab)
    {
        ClearCatalog();

        foreach (ShopItem item in shopTab.catalog.items)
        {
            Instantiate(button, shopMenuContent.transform);
            button.InitializeButton(item);
        }

        currentSelectedTab = shopTab;
    }

    public void ClearCatalog()
    {
        foreach (Transform item in shopMenuContent.transform)
        {
            Destroy(item.gameObject);
        }
    }
}

public enum ShopCurrency
{
    Coins, Money
}
