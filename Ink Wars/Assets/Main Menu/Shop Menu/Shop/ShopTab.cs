using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTab : MonoBehaviour
{
    [SerializeField] private ShopMenu shopMenu;
    private ShopMenu ShopMenu
    {
        get
        {
            if(!shopMenu)
                shopMenu = FindObjectOfType<ShopMenu>();

                return shopMenu;
        }
    }   
    public ShopCatalog catalog;

    public void LoadTab()
    {
        ShopMenu.LoadCatalog(this);
    }
}
