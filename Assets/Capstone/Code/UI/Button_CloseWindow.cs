using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_CloseWindow : MonoBehaviour
{
    public GameObject Window;
    public GameObject Window2;


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

        Window.SetActive(false);
        if (Window2 != null)
        {
            Window2.SetActive(false);
        }
    }
}
