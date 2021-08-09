using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Charge : MonoBehaviour
{
    public TextMeshProUGUI voltageIndicator;
    [SerializeField] private float voltage;
    public float Voltage
    {
        get
        {
            return voltage;
        }
        set
        {
            voltage += value;
            if(voltage >= 12.0f)
            {
                voltageIndicator.SetText("Voltage : " + voltage);
            }
            else
            {
                voltageIndicator.SetText("Warning Low Voltage : " + voltage);
            }
        }
    }
    public virtual void UpdateVolts(float f)
    {
        Voltage = f;
    }
    
}
