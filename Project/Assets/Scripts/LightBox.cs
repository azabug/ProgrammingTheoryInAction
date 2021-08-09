using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBox : Charge
{
    public bool isLit = false;
    public float ticker = 0.0f;
    public LightBulb lightBulb;
    // Start is called before the first frame update
    void Start()
    {
        lightBulb = GameObject.Find("Light").GetComponent<LightBulb>();
        voltageIndicator.SetText("Voltage : " + Voltage);
    }

    // Update is called once per frame
    void Update()
    {
        if(isLit)
        {
            ticker += 0.1f;
            if(ticker >= 1.0f)
            {
                lightBulb.UpdateOutputText();
                UpdateVolts(-0.1f);
                ticker = 0.0f;
            }
        }
        //Debug.Log(Voltage);
    }
    public override void UpdateVolts(float f)
    {
        Voltage = f;
    }
}
