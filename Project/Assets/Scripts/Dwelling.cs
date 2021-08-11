using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwelling : Residential
{
    public BuildingManager buildingManager;
    private void Start()
    {
        //Abstraction
        SetBuildingType();
        SetDwellingType();
    }
    private void Update()
    {

    }
    //Polymorphism
    public override void SetBuildingType()
    {
        TypeOfBuilding = "Dwelling";
    }
    //Polymorphism
    public override void SetDwellingType()
    {
        if (grade == 0)
        {
            DwellingType = "Shack";
        }
        else if (grade == 1)
        {
            DwellingType = "Home";
        }
        else if (grade == 2)
        {
            DwellingType = "Estate";
        }
        else if (grade == 3)
        {
            DwellingType = "Units";
        }
        Debug.Log(": " + DwellingType);
    }

    public void Upgrade()
    {
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
        grade += 1;
        //Instantiate(buildingPrefabTwo, transform);
        SetDwellingType();
        buildingManager.UpdateBuilding(grade, TypeOfBuilding);
    }
}
