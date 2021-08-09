using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public bool chargeState;
    public bool isTracking = true;
    public float ticker = 0;
    public int timer = 0;
    public int timeout = 0;
    public float charge;
    public float magneticForce;
    
    public GameObject[] yinSpheres;
    public GameObject[] yangSpheres;
    public GameObject target;
    public float range;
    public float distance;
    public Vector3 difference = new Vector3();
    public float targetDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        yinSpheres = GameObject.FindGameObjectsWithTag("yinSphere");
        yangSpheres = GameObject.FindGameObjectsWithTag("yangSphere");
    }

    // Update is called once per frame
    void Update()
    {
        if(isTracking)
        {
            ticker += 0.1f;
            if (ticker >= 1.0f)
            {
                if (chargeState)
                {
                    CheckForYinSpheres();
                }
                else
                {
                    CheckForYangSpheres();
                }
                ticker = 0.0f;
            }
        }
        else if(!isTracking)
        {
            ticker += 0.1f;
            if (ticker >= 1.0f)
            {
                timer += 1;
                if(timer >= timeout)
                {
                    isTracking = true;
                    timer = 0;
                    ResetTargetDistance();
                }
            }
        }
    }
    public void CheckForYinSpheres()
    {
        for (int i = 0; i < yinSpheres.Length;i++)
        {
            if(yinSpheres[i] != this)
            {
                difference = transform.position - yinSpheres[i].transform.position;
                distance = difference.magnitude;
                if (distance < range)
                {
                    if (distance < targetDistance)
                    {
                        targetDistance = distance;
                        target = yinSpheres[i];
                        if (!chargeState)
                        {
                            MoveAway();
                            Debug.Log("Check for yin - MoveAway - chargeState = false");
                        }
                        else
                        {
                            MoveTowards();
                            Debug.Log("Check for yin - MoveTowards - chargeState = true");
                        }
                    }
                }
            }
        }
    }
    public void CheckForYangSpheres()
    {
        for (int i = 0; i < yangSpheres.Length; i++)
        {
            if (yangSpheres[i] != this)
            {
                difference = transform.position - yangSpheres[i].transform.position;
                distance = difference.magnitude;
                if (distance < range)
                {
                    if (distance < targetDistance)
                    {
                        targetDistance = distance;
                        target = yangSpheres[i];
                        if (chargeState)
                        {
                            MoveAway();
                            Debug.Log("Check for yang - MoveAway - chargeState = true");
                        }
                        else
                        {
                            MoveTowards();
                            Debug.Log("Check for yang - MoveTowards - chargeState = false");
                        }
                    }
                }
            }
        }
    }
    public void MoveAway()
    {

    }
    public void MoveTowards()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, targetDistance * magneticForce);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("yinSphere") || collision.collider.CompareTag("yangSphere"))
        {
            isTracking = false;
            //ResetTargetDistance();
        }
    }

    public void ResetTargetDistance()
    {
        targetDistance = range;
    }
}
