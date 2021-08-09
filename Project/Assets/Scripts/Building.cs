using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Building : MonoBehaviour
{
    public int grade = 0;
    //Encapsulation
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
    //Call to backing field setting the private string to "Generic"
    //public virtual to be overridden by any child with a public override void execution of "SetBuildingType"
    public virtual void SetBuildingType()
    {
        TypeOfBuilding = "Generic";
    }
}
