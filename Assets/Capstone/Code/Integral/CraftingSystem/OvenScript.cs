using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenScript : MonoBehaviour
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
      

        //FISH
        //is there enough raw fish to cook?
        if (rL.rawFish > 0)
        {
            ////////////////
            //THIS ALWAYS NEEDS TO BE CALLED ANY TIME THAT TIME PASSES IN GAME. COPY AND PASTE THIS INTO EVERY SINGLE ACTION
            rL.VillagerWork();
            //THIS ALWAYS NEEDS TO BE CALLED ANY TIME THAT TIME PASSES IN GAME. COPY AND PASTE THIS INTO EVERY SINGLE ACTION
            ////////////////

            //Add to the hour count
            rL.HourCount = rL.HourCount + 2;
            //Add Cooked fish and delete Raw fish
            rL.rawFish = rL.rawFish - 1;
            rL.Fish_Cooked = rL.Fish_Cooked + 1;
            rL.PrintInfo();
        }
        else
        {
            //print that you dont have enough resources
           print ( "You do not have enough Raw Fish!");
        }

        //Game
        //is there enough raw game to cook?
        if (rL.rawGame > 0)
        {
            ////////////////
            //THIS ALWAYS NEEDS TO BE CALLED ANY TIME THAT TIME PASSES IN GAME. COPY AND PASTE THIS INTO EVERY SINGLE ACTION
            rL.VillagerWork();
            //THIS ALWAYS NEEDS TO BE CALLED ANY TIME THAT TIME PASSES IN GAME. COPY AND PASTE THIS INTO EVERY SINGLE ACTION
            ////////////////

            //Add to the hour count
            rL.HourCount = rL.HourCount + 2;
            //Add Cooked fish and delete Raw game
            rL.rawGame = rL.rawGame - 1;
            rL.Game_Cooked = rL.Game_Cooked + 1;
            rL.PrintInfo();
        }
        else
        {
            //print that you dont have enough resources
            print("You do not have enough Raw Game!");
        }
    }

}
