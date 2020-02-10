using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_OpenWindow : MonoBehaviour
{

    public GameObject Window;
    public GameObject Window2;
    public GameObject WindowtoClose;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {

        Window.SetActive(true);
        if (Window2 != null)
        {
            Window2.SetActive(true);
        }
        WindowtoClose.SetActive(false);
    }
}
