using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    private ItemsAssets item = null;
    
    private Sprite Sprite
    {
        get
        {
            return GetComponent<Image>().sprite;
        }
        set
        {
            GetComponent<Image>().sprite = value;
        }
    }
    private Text PriceText 
    {
        get
        {
            return GetComponentInChildren<Text>();
        }
    }
    [SerializeField] private ShopItemInfo info;
    public void InitializeButton(ShopItem shopItem)
    {
        item = shopItem.item;
        Sprite = item.itemImg;

        info = shopItem.info;

        PriceText.text = info.price.ToString();
    }
}
