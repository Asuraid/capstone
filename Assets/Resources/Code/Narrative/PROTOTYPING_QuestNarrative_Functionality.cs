using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

namespace TeamMars.Capstone.Manager.Resources
{

    public class PROTOTYPING_QuestNarrative_Functionality : MonoBehaviour
    {
        public bool isEvent = true;
        public bool EventChosen = false;

        public int rawFish = 0;

        void Start()
        {
            isEvent = true;

        }

        // Update is called once per frame
        void Update()
        {



            print(rawFish);


            if (isEvent)
            {
                EventChosen = false;
                CallQuestEvent_Minor((int)Random.Range(1,3.99f));
                isEvent = false;
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
            DialogueManager.StartConversation("Quest_Minor_Prefab_", gameObject.transform, gameObject.transform, 0);

            switch (RandomEventNumber)
            {
                #region Event Number 1
                //Random Event #
                case 1:
                    //Event title
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED?");
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
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Giant meatballs fall from the sky");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 30);
                    #endregion
                    print("Load");
                    break;
                #endregion
                #region Event Number 2
                //Random Event #
                case 2:
                    //Event title
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED?");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "A second moon appears in the night sky");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "Giant worm monsters appear from the earth");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "A giant stone alien ship lands in midwestern America");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 30);
                    #endregion
                    print("Load");
                    break;
                #endregion
                #region Event Number 3
                //Random Event #
                case 3:
                    //Event title
                    DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED?");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "Some random girl picks up a lighty stick and rules the galaxy");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 10);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 10);
                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "Swirly red and black obelisk dubbed the 'Marker' ");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 20);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 20);
                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "Coffee is officially banned. Chaos ensues");
                    #region Functionality
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_RawGameAdd", 30);
                    DialogueLua.SetVariable("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd", 30);
                    #endregion
                    print("Load");
                    break;
                    #endregion
            }

        }

        //EXECUTE THE DETAILS FROM THE STORED VALUES
        void ExecuteQuestEvent_Minor()
        {
            print("Execute");
            // IF CHOICE #1 IS MADE
            if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 1)
            {
                print("Choice #1");
                GameManager.Instance.rawFish += DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_RawFishAdd")).asInt;
                GameManager.Instance.cookedFish += DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_CookedFishAdd")).asInt;
                GameManager.Instance.rawGame += DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_RawGameAdd")).asInt;
                GameManager.Instance.cookedGame += DialogueLua.GetVariable(("Quest_Minor_EventChoice_1_Functionality_CookedGameAdd")).asInt;
                DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
                EventChosen = false;
            }
            // IF CHOICE #2 IS MADE
            if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 2)
            {
                print("Choice #2");
                GameManager.Instance.rawFish += DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_RawFishAdd")).asInt;
                GameManager.Instance.cookedFish += DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_CookedFishAdd")).asInt;
                GameManager.Instance.rawGame += DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_RawGameAdd")).asInt;
                GameManager.Instance.cookedGame += DialogueLua.GetVariable(("Quest_Minor_EventChoice_2_Functionality_CookedGameAdd")).asInt;
                DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
                EventChosen = false;
            }
            // IF CHOICE #3 IS MADE
            if (DialogueLua.GetVariable(("Quest_Minor_EventChosen")).asInt == 3)
            {
                print("Choice #3");
                GameManager.Instance.rawFish += DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_RawFishAdd")).asInt;
                GameManager.Instance.cookedFish += DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_CookedFishAdd")).asInt;
                GameManager.Instance.rawGame += DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_RawGameAdd")).asInt;
                GameManager.Instance.cookedGame += DialogueLua.GetVariable(("Quest_Minor_EventChoice_3_Functionality_CookedGameAdd")).asInt;
                DialogueLua.SetVariable(("Quest_Minor_EventChosen"), 0);
                EventChosen = false;
            }
        }
    }
}