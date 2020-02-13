using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

namespace TeamMars.Capstone.Manager.Resources
{
   
    public class PROTOTYPING_QuestNarrative_Functionality : MonoBehaviour
    {

        public Pause_UnpauseGame pauseScript;


        public bool isEvent = false;
        public bool EventChosen = false;
        public int WhichMinorEvent = 0;



        public bool isUsingStorySystemUI;
        public GameObject[] StoryItems = new GameObject[3];
        public GameObject StorySystem;


        void Start()
        {
            isEvent = false;

            

            isUsingStorySystemUI = true;
            if (isUsingStorySystemUI)
            {
                for (int i= 0; i < StoryItems.Length;i++)
                {
                    StoryItems[i] = StorySystem.transform.GetChild(i).gameObject;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            //print(Time.timeScale);
            if (Input.GetKeyDown("i"))
            {
        
                isEvent = true;
                WhichMinorEvent++;
            }


            if (isEvent)
            {
                pauseScript.PauseGame();
                
                EventChosen = false;
                CallQuestEvent_Minor(WhichMinorEvent);

            }
            if (EventChosen == false)
            {
                ExecuteQuestEvent_Minor();
            }
            else
            {
     
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
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "A trader appears in your town; He asks for directions");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "Trade food for supplies");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "Offer him directions");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Attack the trader and steal his stuff");
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
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "The moon is full tonight, and some village folk are acting strange");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "Pray to the moon god");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "Ignore the situation");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Host a sacrifice");
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
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "The pond is becoming flooded, It is becoming difficult to fish");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "Sell more fish to offset the costs");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "Stop fishing and ration the remaining supplies");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Force workers to build more fishing boats");
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


                if (isUsingStorySystemUI)
                {
                    print(StoryItems[WhichMinorEvent - 1].name);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).gameObject.SetActive(true);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(2).gameObject.SetActive(false);
                }





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



                if (isUsingStorySystemUI)
                {
                    print(StoryItems[WhichMinorEvent - 1].name);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).gameObject.SetActive(true);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(2).gameObject.SetActive(false);
                }



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


                if (isUsingStorySystemUI)
                {
                    print(StoryItems[WhichMinorEvent - 1].name);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).gameObject.SetActive(true);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
                    StoryItems[WhichMinorEvent - 1].transform.GetChild(1).GetChild(2).gameObject.SetActive(true);
                }


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