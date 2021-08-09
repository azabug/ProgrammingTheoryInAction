using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{
    public LightBox lightBox;
    public LightBulb lightBulb;
    public Light lightSource;
    private void Start()
    {
        lightBox = GameObject.Find("LightBox").GetComponent<LightBox>();
        lightBulb = GameObject.Find("Light").GetComponent<LightBulb>();
    }
    private void OnMouseDown()
    {
        Debug.Log(lightBox.isLit);
        if(!lightBox.isLit)
        {
            transform.position = new Vector3(-5.55f, 0.25f, -1.3f);
            lightSource.intensity = lightBulb.output;
            lightBox.isLit = true;
        }
        else
        {
            transform.position = new Vector3(-5.55f, 0.25f, -1.4f);
            lightSource.intensity = 0;
            lightBox.isLit = false;
            lightBulb.UpdateOutputText();
        }
    }
    public void CutPower()
    {
        transform.position = new Vector3(-5.55f, 0.25f, -1.4f);
        lightSource.intensity = 0;
        lightBox.isLit = false;
    }
}
