using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PillarMonitor : MonoBehaviour
{
    public int clickCount = 0;
    public Button p1Button;
    public Button p2Button;
    public Button p3Button;
    public Button p4Button;
    public string selected = "";
    public bool isDisplaying, hasClickedRed, hasClickedGreen, hasClickedBlue, hasClickedYellow = false;
    // Start is called before the first frame update
    void Start()
    {
        p1Button = GameObject.Find("RedButton").GetComponent<Button>();
        p1Button.onClick.AddListener(Red);
        p1Button.onClick.AddListener(ClickCount);
        p2Button = GameObject.Find("GreenButton").GetComponent<Button>();
        p2Button.onClick.AddListener(Green);
        p2Button.onClick.AddListener(ClickCount);
        p3Button = GameObject.Find("BlueButton").GetComponent<Button>();
        p3Button.onClick.AddListener(Blue);
        p3Button.onClick.AddListener(ClickCount);
        p4Button = GameObject.Find("YellowButton").GetComponent<Button>();
        p4Button.onClick.AddListener(Yellow);
        p4Button.onClick.AddListener(ClickCount);
    }

    // Update is called once per frame
    private void ClickCount()
    {
        clickCount += 1;
        //Debug.Log("Monitor : "+clickCount);
        HasClickedAll();
    }
    private void Red()
    {
        hasClickedRed = true;
        //Debug.Log("Selection : Red");
    }
    private void Green()
    {
        hasClickedGreen = true;
        //Debug.Log("Selection : Green");
    }
    private void Blue()
    {
        hasClickedBlue = true;
        //Debug.Log("Selection : Blue");
    }
    private void Yellow()
    {
        hasClickedYellow = true;
        //Debug.Log("Selection : Yellow");
    }
    private void HasClickedAll()
    {
        if(hasClickedRed && hasClickedGreen && hasClickedBlue && hasClickedYellow)
        {
            Debug.Log("HasClickedAll");
        }
    }
}
