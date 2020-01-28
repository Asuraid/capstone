using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

namespace TeamMars.Capstone.Manager.Resources
{

    public class PROTOTYPING_QuestNarrative_Functionality : MonoBehaviour
    {
        public bool isEvent = false;
        public bool EventChosen = false;
        public int WhichMinorEvent = 0;

        void Start()
        {
            isEvent = false;

        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown("i"))
            {
                isEvent = true;
                WhichMinorEvent = 1;
            }
            if (Input.GetKeyDown("o"))
            {
                isEvent = true;
                WhichMinorEvent = 2;
            }
            if (Input.GetKeyDown("p"))
            {
                isEvent = true;
                WhichMinorEvent = 3;
            }


            if (isEvent)
            {
                EventChosen = false;
                CallQuestEvent_Minor(WhichMinorEvent);

            }
            if (EventChosen == false)
            {
                ExecuteQuestEvent_Minor();
            }



        }



        //STORE ALL OF THE VALUES HERE
        void CallQuestEvent_Minor(int RandomEventNumber)
        {
            //This calls the prefab that holds the general structure for the quest picker
            DialogueManager.StartConversation("Quest_Minor_Prefab", gameObject.transform, gameObject.transform, 0);

            switch (RandomEventNumber)
            {
                #region Event Number 1
                //Random Event #
                case 1:
                    //Event title
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED? #1");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "German Robot from the future");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "Xenomorph Attack");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Giant meatballs fall from the sky");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_RawFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_CookedFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_RawGameAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_CookedGameAdd", 30);
                    #endregion
                    print("Load");
                    break;


                case 2:
                    //Event title
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED? #2");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "Two Moons appear in the sky");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "A villager falls in love with a primordial shapeshifter");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Weird rock formations appear during a routine dig");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_RawFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_CookedFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_RawGameAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_CookedGameAdd", 30);
                    #endregion
                    print("Load");
                    break;

                case 3:
                    //Event title
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED? #3");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "Giant worm monsters appear from the sand dunes");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "One of your villagers fall sick with an unknown illness");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "A trader with two different coloured eyes shows up");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_RawFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_CookedFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_RawGameAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3_Functionality_CookedGameAdd", 30);
                    #endregion
                    print("Load");
                    break;
                    #endregion
            }

        }

        //EXECUTE THE DETAILS FROM THE STORED VALUES
        void ExecuteQuestEvent_Minor()
        {
            // IF CHOICE #1 IS MADE
            if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 1)
            {
                print("Choice #1");
                ResourceManager.Instance.AddRawFish(DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_RawFishAdd")).asInt);
                ResourceManager.Instance.AddCookedFish(DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd")).asInt);
                ResourceManager.Instance.AddRawGame(DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_RawGameAdd")).asInt);
                ResourceManager.Instance.AddCookedGame(DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd")).asInt);
                DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
                EventChosen = true;
                isEvent = false;
            }
            // IF CHOICE #2 IS MADE
            if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 2)
            {
                print("Choice #2");
                ResourceManager.Instance.AddRawFish(DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_RawFishAdd")).asInt);
                ResourceManager.Instance.AddCookedFish(DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd")).asInt);
                ResourceManager.Instance.AddRawGame(DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_RawGameAdd")).asInt);
                ResourceManager.Instance.AddCookedGame(DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd")).asInt);
                DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
                EventChosen = true;
                isEvent = false;
            }
            // IF CHOICE #3 IS MADE
            if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 3)
            {
                print("Choice #3");
                ResourceManager.Instance.AddRawFish(DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_RawFishAdd")).asInt);
                ResourceManager.Instance.AddCookedFish(DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_CookedFishAdd")).asInt);
                ResourceManager.Instance.AddRawGame(DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_RawGameAdd")).asInt);
                ResourceManager.Instance.AddCookedGame(DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_CookedGameAdd")).asInt);
                DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
                EventChosen = true;
                isEvent = false;
            }
        }
    }
}