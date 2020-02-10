using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondScript : MonoBehaviour
{

    // What UI to display when hover
    public GameObject UI_Hover_text;
    public GameObject UI_Click_text;



    // Start is called before the first frame update
    void Start()
    {
        UI_Hover_text.SetActive(false);
        UI_Click_text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        UI_Hover_text.SetActive(true);

    }
    private void OnMouseExit()
    {
        UI_Hover_text.SetActive(false);


    }
    private void OnMouseDown()
    {
        UI_Click_text.SetActive(true);
        //handled in a seperate script to close window
    }


}
