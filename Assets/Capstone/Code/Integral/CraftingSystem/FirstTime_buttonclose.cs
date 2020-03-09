using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTime_buttonclose : MonoBehaviour
{
    public FirstTime_Introduction firstTime_Introduction;

    // Start is called before the first frame update
    void Start()
    {
        firstTime_Introduction = transform.parent.parent.GetComponent<FirstTime_Introduction>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnMouseDown()
    {
        firstTime_Introduction.isDone = true;
    }
}
