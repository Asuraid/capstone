using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingTent_firstTime : MonoBehaviour
{

    public GameObject TentGameobject;
    public GameObject UI_Background;
    bool isDone = false;
    // Start is called before the first frame update
    void Start()
    {
        isDone = false;
        TentGameobject.SetActive(false);
        UI_Background.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (isDone == false)
        {
            TentGameobject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            TentGameobject.transform.position = new Vector3(TentGameobject.transform.position.x, TentGameobject.transform.position.y,transform.position.z);
            TentGameobject.SetActive(true);
            UI_Background.SetActive(false);
            isDone = true;
        }
    }
}
