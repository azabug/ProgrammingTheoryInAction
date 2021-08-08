using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] buildings;
    public GameObject tile;

    public void InitialiseBuilding(int grade)
    {
        buildings[grade].SetActive(true);
    }
    public void UpdateBuilding(int grade)
    {
        int c = buildings.Length - 1;
        if(c >= grade)
        {
            int exGrade = grade - 1;
            buildings[exGrade].SetActive(false);
            buildings[grade].SetActive(true);
        }
        //Debug.Log(grade);
    }
}
