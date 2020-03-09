using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSize : MonoBehaviour
{
    public float lerpSizeIncrease = .5f;

    public GameObject indicator;

    private void OnMouseEnter()
    {
        print("the mouse is inside");

        Vector3 scale = new Vector3((indicator.transform.localScale.x + lerpSizeIncrease), (indicator.transform.localScale.y + lerpSizeIncrease), indicator.transform.localScale.z);
        indicator.transform.localScale = Vector3.Lerp(indicator.transform.localScale, scale, Time.deltaTime);
    }
    
}