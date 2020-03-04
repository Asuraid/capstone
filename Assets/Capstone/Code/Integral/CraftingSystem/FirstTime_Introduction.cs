using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTime_Introduction : MonoBehaviour
{
    public GameObject OnClick;
    public GameObject OnHover;
    public GameObject HoverHaze;

    public bool isDone = false;
    // Start is called before the first frame update
    void Start()
    {
        if (HoverHaze != null)
        {
            HoverHaze.SetActive(true);
        }
        OnHover.SetActive(false);
        OnClick.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDone)
        {
            print("hi");
            OnHover.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void OnMouse()
    {
        OnHover.SetActive(true);
    }
    void OnMouseOff()
    {
        OnHover.SetActive(false);
    }
    void OnMouseDown()
    {

            HoverHaze.SetActive(false);
        
        OnClick.SetActive(true);
        
        //print(HoverSomething.activeSelf);
    }
    


}
