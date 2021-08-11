using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] dwellings;
    public GameObject[] shops;
    public GameObject[] buildings;
    public GameObject tile;

    public void InitialiseBuilding(int grade, string type)
    {
        if(type == "Dwelling")
        {
            dwellings[grade].SetActive(true);
        }
        else if (type == "Shop")
        {
            shops[grade].SetActive(true);
        }
        
    }
    public void UpdateBuilding(int grade, string type)
    {
        int c = 0;
        Debug.Log(grade + ", " + type);
        if (type == "Dwelling")
        {
            c = dwellings.Length - 1;
            buildings = dwellings;
        }
        else if (type =="Shop")
        {
            c = shops.Length - 1;
            buildings = shops;
        }
        
        if(c >= grade)
        {
            int exGrade = grade - 1;
            buildings[exGrade].SetActive(false);
            buildings[grade].SetActive(true);
        }
        //Debug.Log(grade);
    }
}
