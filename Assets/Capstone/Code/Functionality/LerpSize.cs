using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSize : MonoBehaviour
{
    public float lerpSizeIncrease = .5f;

    public GameObject indicator;

    Vector3 originalSize;
    Vector3 scale;

    public float scalingSizeTimer;

    /// <summary>
    /// Set up the sizes to lerp to, including original size and the lerped size.
    /// </summary>
    private void Start()
    {
        originalSize = new Vector3(indicator.transform.localScale.x, indicator.transform.localScale.y, indicator.transform.localScale.x);
        scale = new Vector3((indicator.transform.localScale.x + lerpSizeIncrease), (indicator.transform.localScale.y + lerpSizeIncrease), indicator.transform.localScale.z);
    }

    /// <summary>
    /// On the mouse entering the trigger area, execute lerping size.
    /// </summary>
    private void OnMouseEnter()
    {
        iTween.ScaleTo(indicator, scale, scalingSizeTimer);
    }

    /// <summary>
    /// On the mouse exiting the trigger area, return to original size.
    /// </summary>
    private void OnMouseExit()
    {
        iTween.ScaleTo(indicator, originalSize, 2f);
    }

}