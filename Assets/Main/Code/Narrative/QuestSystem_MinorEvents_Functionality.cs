using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PixelCrushers.DialogueSystem;

public class QuestSystem_MinorEvents_Functionality : MonoBehaviour
{



    /////////////////////////////////////////////////////////////////////////////////////////
    public ResourcesList resourcesList;

    //these variables are used for math only please dont touch
    int rawFishAdd_temp = 0;
    int cookedFishAdd_temp = 0;
    int rawGameAdd_temp = 0;
    int cookedGameAdd_temp = 0;
    int foodSupply_temp = 0;













    /////////////////////////////////////////////////////////////////////////////////////////



    //This is important to show that selecting a choice in game can change a back end variable. By proving that I can do this, I can later call functions from options selected
    public int choicevariable = 0;


    // Start is called before the first frame update
    void Start()
    {
        QuestCall_Minor();
    }

    // Update is called once per frame
    void Update()
    {
    

        //Calls the correct functions based on player choice
        if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 1)
        {
            print("Event_Minor_Choice#1");
            RunFunctions(rawFishAdd_temp, cookedGameAdd_temp, rawGameAdd_temp, cookedGameAdd_temp, foodSupply_temp);
        }
        if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 2)
        {
            print("Event_Minor_Choice#2");
        }
        if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 3)
        {
            print("Event_Minor_Choice#3");
        }

        //When the player makes a choice, this resets their choice variable so that functions dont repeat multiple times
        if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt != 0)
        {
            DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
        }

        //Chooses a function based on the three choices


    }

    public void QuestCall_Minor()
    {

        DialogueManager.StartConversation("Quest_Minor_Prefab", gameObject.transform, gameObject.transform, 0);



        DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED?");

        DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "EARTHQUAKE");
        ///////////////////////////////////////////////////////////////////
            SetFunctionValues(100000, 0, 0, 0, 0);
        ///////////////////////////////////////////////////////////////////
        DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "BUILDING COLLAPSE");
        DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "ELDRITCH HORROR");
    }


    //THIS IS PROBABLY A BAD WAY OF DOING IT BUT I HAVE NO CLUE HOW ELSE TO DO IT. ALL OF THE POSSIBLE VARIABLES IN THE GAME SHOULD BE LISTED HERE. THEY WILL BE CHANGED ALL AT ONCE
    //THIS IS WHERE VALUES ARE LOADED FROM THE SETFUNCTIONVALUES METHOD AND INTO HERE
    void RunFunctions(int rawFishAdd, int cookedFishAdd, int rawGameAdd, int cookedGameAdd,int foodSupply)
    {
        rawFishAdd = rawFishAdd_temp;
        cookedFishAdd = cookedFishAdd_temp;
        rawGameAdd = rawGameAdd_temp;
        cookedGameAdd = cookedGameAdd_temp;
        foodSupply = foodSupply_temp;




        resourcesList.Fish_Raw += rawFishAdd;
        resourcesList.Fish_Cooked += cookedFishAdd;
        resourcesList.Game_Raw += rawGameAdd;
        resourcesList.Game_Cooked += cookedGameAdd;
        resourcesList.FoodSupply += foodSupply;




        //reset temp methods
        rawFishAdd_temp = 0;
        cookedFishAdd_temp = 0;
        rawGameAdd_temp = 0;
        cookedGameAdd_temp = 0;
        foodSupply_temp = 0;
    }


    //THIS GETS CALLED EVERY TIME THAT A CHOICE IS MADE. HERE IS WHERE DEVELOPERS CAN INPUT CHANGE VALUES
    void SetFunctionValues(int rawFishAdd, int cookedFishAdd, int rawGameAdd, int cookedGameAdd, int foodSupply)
    {
        rawFishAdd_temp = rawFishAdd;
        cookedFishAdd_temp = cookedFishAdd;
        rawGameAdd_temp = rawGameAdd;
        cookedGameAdd_temp = cookedGameAdd;
        foodSupply_temp = foodSupply;
    }


}
