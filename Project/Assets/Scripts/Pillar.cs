using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pillar : MonoBehaviour
{
    public static Pillar Instance { get; set; }

    public PillarMonitor pillarMonitor;
    public TextMeshProUGUI concept;
    public TextMeshProUGUI sampleCode;
    public Button pButton;
    public GameObject sample;
    public Color pillarColor = Color.white;
    
    protected Vector3 objectPosition = new Vector3(0, 0, 0);
    protected Vector3 objectScale = new Vector3(1, 2, 1);

    protected string objectType = "Pillar";
    
    public string pillarName;
    public string conceptArticulate;
    
    public bool isDisplaying = false;
    public bool isLifting = false;
    public bool isScrolling = false;
    public bool isScrollExit = false;

    public float scrollSpeed = 2000.0f;

    public void Responder()
    {
        if (!isLifting && !isScrolling)
        {
            scrollSpeed = 2000.0f;
            isDisplaying = true;
            isScrolling = true;
            isLifting = true;
            DisplayName();
        }
    }
    public void DisplayName()
    {
        concept.gameObject.SetActive(true);
        concept.SetText(conceptArticulate + ".");
    }
    public void LiftPillar()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10.0f);
        if (transform.position.y >= 8.0f)
        {
            isLifting = false;
        }
    }
    public void EnterScrollText(float multiplier)
    {
        if (sampleCode.gameObject.transform.position.x < 400.0f)
        {
            sampleCode.gameObject.transform.Translate(Vector3.right * Time.deltaTime * multiplier);
        }
        else if (sampleCode.gameObject.transform.position.x > 400.0f)
        {
            isScrolling = false;
            isScrollExit = true;
        }
    }
    public void ExitScrollText(float multiplier)
    {
        if (sampleCode.gameObject.transform.position.x > -600.0f)
        {
            sampleCode.gameObject.transform.Translate(Vector3.left * Time.deltaTime * multiplier);
        }
        else if (sampleCode.gameObject.transform.position.x <= -600.0f)
        {
            isScrolling = false;
            isScrollExit = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isDisplaying)
        {
            isScrolling = true;
            isScrollExit = true;
            concept.gameObject.SetActive(false);
        }
    }
}
