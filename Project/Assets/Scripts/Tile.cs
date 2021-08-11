using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public BuildingManager buildingManager;
    public Vector3 tilePosition;
    private bool isOccupied = false;
    public MeshRenderer tileRenderer;
    public Material material;
    public string occupationType;

    private void Start()
    {
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
        tilePosition = transform.position;
    }
    public void OnUpgrade()
    {
        if(isOccupied)
        {
            if (occupationType == "Shop")
            {
                Garage shop = GameObject.FindGameObjectWithTag("Shop").GetComponent<Garage>();
                shop.Upgrade();
            }
            else if (occupationType == "Dwelling")
            {
                Dwelling dwelling = GameObject.FindGameObjectWithTag("Dwelling").GetComponent<Dwelling>();
                dwelling.Upgrade();
            }
        }
        
    }
    public void OnMouseOver()
    {
        MeshRenderer tileRenderer = gameObject.GetComponent<MeshRenderer>();
        material = tileRenderer.material;
        material.color = new Color(0.0f, 1.0f, 1.0f, 1.0f);
    }
    public void OnMouseExit()
    {
        MeshRenderer tileRenderer = gameObject.GetComponent<MeshRenderer>();
        material = tileRenderer.material;
        material.color = new Color(0.2055892f, 0.4150943f, 0.3361504f, 1.0f);
    }
    public void OnMouseDown()
    {
        if(!isOccupied)
        {
            buildingManager.InitialiseBuilding(0, occupationType);
            isOccupied = true;
        }
    }
}
