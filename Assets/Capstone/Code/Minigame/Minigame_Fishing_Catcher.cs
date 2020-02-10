using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_Fishing_Catcher : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = new Vector3(Input.mousePosition.x, 0.0f, -2);
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        this.transform.position = new Vector3(mouse.x, Camera.main.transform.position.y, -7);
    }
}
