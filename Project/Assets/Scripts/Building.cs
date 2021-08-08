using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Building : MonoBehaviour
{
    public int grade = 0;
    private string typeOfBuilding;
    public string TypeOfBuilding
    {
        get
        {
            return typeOfBuilding;
        }
        set
        {
            typeOfBuilding = value;
        }
    }
    public virtual void SetBuildingType()
    {
        TypeOfBuilding = "Generic";
    }
}
