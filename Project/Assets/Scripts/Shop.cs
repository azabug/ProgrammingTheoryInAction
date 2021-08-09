using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : Building
{
    //Encapsulation
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
    //Call to backing field setting the private string to "Generic"
    //public virtual to be overridden by Garage or another shop variant
    public virtual void SetShopType()
    {
        ShopType = "Generic";
    }
}
