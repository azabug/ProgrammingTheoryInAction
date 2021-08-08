using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garage : Shop
{
    public BuildingManager buildingManager;
    private void Start()
    {
        
        SetBuildingType();
        SetShopType();
    }
    private void Update()
    {
        
    }
    public override void SetBuildingType()
    {
        TypeOfBuilding = "Shop";
    }
    public override void SetShopType()
    {
        if (grade == 0)
        {
            ShopType = "Garage";
        }
        else if (grade == 1)
        {
            ShopType = "Service Station";
        }

        Debug.Log(": " + ShopType);
    }
    
    public void Upgrade()
    {
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
        grade += 1;
        //Instantiate(buildingPrefabTwo, transform);
        SetShopType();
        buildingManager.UpdateBuilding(grade);
    }
}
