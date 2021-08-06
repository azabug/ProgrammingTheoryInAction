using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PillarType : Pillar
{
    private string buttonName;
    private string sampleName;

    private void Start()
    {
        pillarMonitor = GameObject.Find("Platform").GetComponent<PillarMonitor>();
        buttonName = pillarName + "Button";
        sampleName = pillarName + "Code";
        sampleCode = GameObject.Find(sampleName).GetComponent<TextMeshProUGUI>();
        pButton = GameObject.Find(buttonName).GetComponent<Button>();
        pButton.onClick.AddListener(Responder);
    }
    private void FixedUpdate()
    {
        //if (pillarMonitor.isDisplaying)
        //{
            if (isLifting)
            {
                LiftPillar();
            }
            if (isScrolling)
            {
                if (!isScrollExit)
                {
                    EnterScrollText(scrollSpeed);
                }
                else if (isScrollExit)
                {
                    ExitScrollText(scrollSpeed);
                }
            }
        //}
    }
    
}