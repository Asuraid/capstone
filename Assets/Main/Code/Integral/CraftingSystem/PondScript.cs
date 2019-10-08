using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondScript : MonoBehaviour
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
        ////////////////
        //THIS ALWAYS NEEDS TO BE CALLED ANY TIME THAT TIME PASSES IN GAME. COPY AND PASTE THIS INTO EVERY SINGLE ACTION
        rL.VillagerWork();
        //THIS ALWAYS NEEDS TO BE CALLED ANY TIME THAT TIME PASSES IN GAME. COPY AND PASTE THIS INTO EVERY SINGLE ACTION
        ////////////////

        //Add to the hour count
        rL.HourCount = rL.HourCount + 2;
        //Gather fish
        rL.Fish_Raw = rL.Fish_Raw + 1;
        rL.PrintInfo();
    }

}
