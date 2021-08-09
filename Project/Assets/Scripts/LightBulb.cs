using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LightBulb : MonoBehaviour
{
    public float optimumInput;
    public float output;
    public float activeOutput;
    public Light lightSource;
    public LightBox lightBox;
    public PowerButton powerButton;
    public TextMeshProUGUI outputText;
    // Start is called before the first frame update
    void Start()
    {
        powerButton = GameObject.Find("PowerButton").GetComponent<PowerButton>();
        lightBox = GameObject.Find("LightBox").GetComponent<LightBox>();
        lightSource.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(lightBox.isLit)
        {
            float amt = (optimumInput - lightBox.Voltage) * 0.000314159265359f;
            lightSource.intensity -= amt;
            output = lightSource.intensity;
            if (lightSource.intensity <= 0.2f)
            {
                lightSource.intensity = 0;
                lightBox.isLit = false;
                powerButton.CutPower();
                UpdateOutputText();
            }
        }
    }
    public void UpdateOutputText()
    {
        activeOutput = lightSource.intensity;
        float watts = activeOutput * 10;
        outputText.SetText("Output in Watts : " + watts);
    }
}
