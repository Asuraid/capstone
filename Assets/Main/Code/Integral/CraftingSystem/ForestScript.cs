using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestScript : MonoBehaviour
{
    public GameObject GameManager;
    public ResourcesList rL;
    // Start is called before the first frame update
    void Start()
    {
        rL = GameManager.GetComponent<ResourcesList>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        //Add to the hour count
        rL.HourCount = rL.HourCount + 2;
        //Gather Game
        rL.Game_Raw = rL.Game_Raw + 1;
        rL.PrintInfo();
    }

}
