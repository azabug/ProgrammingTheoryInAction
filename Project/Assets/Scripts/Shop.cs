using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : Building
{
    private string shopType;
    public string ShopType
    {
        get
        {
            return shopType;
        }
        set
        {
            shopType = value;
        }
    }
    
    public virtual void SetShopType()
    {
        ShopType = "Generic";
    }
}
