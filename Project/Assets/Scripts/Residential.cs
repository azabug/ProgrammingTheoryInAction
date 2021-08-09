using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Residential : Building
{
    private string dwellingType;
    public string DwellingType
    {
        get
        {
            return dwellingType;
        }
        set
        {
            dwellingType = value;
        }
    }
    //Call to backing field setting the private string to "Medium Density"
    //public virtual to be overridden by Dwelling or another Residential variant
    public virtual void SetDwellingType()
    {
        DwellingType = "Medium Density";
    }
}
