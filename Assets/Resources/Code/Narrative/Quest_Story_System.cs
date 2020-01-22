using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;



namespace TeamMars.Capstone.Manager.Resources
{

    public class Quest_Story_System : MonoBehaviour
    {

        #region PROMPT
        /*
         Every first day of the month, a player is given an Event
         This event has a Good(+1) Neutral(0) and Bad choice(-1).
         Every 5 days after, there is another event
         This gives a total of 5 events for 25 days
         At the end of the month(25 days), all of the choices are added up and divided by 5
         This number is your average choice for that month
         This goes on for 4 months
         At the end, there is one final choice.
         All of your end choices are added up and divided by 5
         This final number determines your ending
        */
        #endregion

        #region CONTROLS
        /*
        "I" is a positive choice
        "O" is a neutral choice
        "P" is a negative choice
        print statements will guide you
        */
        #endregion

        public int storyDay = 0;
        int storyMonth = 4;
        int month_1_score = 0;
        int overallScore = 0;
        public int DayScore_1 = 0;
        bool isGame;



        public bool isEvent = false;
        public bool EventChosen = true;
        public int WhichStoryStep = 0;




        /// <summary>
        /// 
        /// IsEvent determines whether there is an Event being called. As soon as it is called, it is set to false
        /// EventChosen determines whether the player has made a choice or not. this keeps multiple events or choices from happenning or overlapping
        /// These two should be mutually exclusive. When one is true, the other is not. And Vice Versa
        /// </summary>




        // Start is called before the first frame update
        void Start()
        {
            isEvent = false;
            EventChosen = true;


        print("Story Day = " + storyDay);
            print("Player Karma = " + overallScore);
        }

        // Update is called once per frame
        void Update()
        {
            if (isEvent == false)
            {
               if ( Input.GetKeyDown(KeyCode.Alpha1))
                {
                    isEvent = true;
                    WhichStoryStep = 1;
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    isEvent = true;
                    WhichStoryStep = 2;
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    isEvent = true;
                    WhichStoryStep = 3;
                }

            }
                if (isEvent)
                {
                    EventChosen = false;
                    CallStoryDialogue(WhichStoryStep);

                }
                if (EventChosen == false)
                {
                    ExecuteStoryDialogue();

                }





           

                    if (storyMonth > 0)
                    {
                        isGame = true;

                if (isEvent)
                {

                    if (storyDay == 5)
                    {
                        storyDay = 0;
                        print("END OF MONTH");
                        month_1_score = DayScore_1;
                        DayScore_1 = 0;
                        print("FirstMonthScore =" + month_1_score);
                        overallScore += month_1_score;
                        print(overallScore);
                        storyMonth = storyMonth - 1;
                    }


                }

                    


                }
            
        

            
            if (storyMonth <= 0)
            {
                if (isGame)
                {
                    print("END" + "FINAL KARMA = " + overallScore);
                    isGame = false;


                }
            }

        }

        void Disable()
        {
            EventChosen = false;
        }
        void CallStoryDialogue(int WhichStoryStep)
        {
            switch (WhichStoryStep)
            {
                case 1:
                    //This calls the prefab that holds the general structure for the quest picker
                    DialogueManager.StartConversation("Quest_Story_Prefab", gameObject.transform, gameObject.transform, 0);


                    //Event title
                    DialogueLua.SetVariable("Quest_Story_EventTitle", "Story Event 1");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Story_EventChoice_1", "Story Event Choice 1");
                    #region Functionality

                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Story_EventChoice_2", "Story Event Choice 2");
                    #region Functionality

                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Story_EventChoice_3", "Story Event Choice 3");
                    #region Functionality

                    #endregion
                    print("Story Load");
                    break;

                case 2:
                    //This calls the prefab that holds the general structure for the quest picker
                    DialogueManager.StartConversation("Quest_Story_Prefab", gameObject.transform, gameObject.transform, 0);


                    //Event title
                    DialogueLua.SetVariable("Quest_Story_EventTitle", "Story Event 2");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Story_EventChoice_1", "Story Event Choice 1");
                    #region Functionality

                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Story_EventChoice_2", "Story Event Choice 2");
                    #region Functionality

                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Story_EventChoice_3", "Story Event Choice 3");
                    #region Functionality

                    #endregion
                    print("Story Load");
                    break;
                case 3:
                    //This calls the prefab that holds the general structure for the quest picker
                    DialogueManager.StartConversation("Quest_Story_Prefab", gameObject.transform, gameObject.transform, 0);


                    //Event title
                    DialogueLua.SetVariable("Quest_Story_EventTitle", "Story Event 3");
                    //Event Choice #1
                    DialogueLua.SetVariable("Quest_Story_EventChoice_1", "Story Event Choice 1");
                    #region Functionality

                    #endregion
                    //Event Choice #2
                    DialogueLua.SetVariable("Quest_Story_EventChoice_2", "Story Event Choice 2");
                    #region Functionality

                    #endregion
                    //Event Choice #3
                    DialogueLua.SetVariable("Quest_Story_EventChoice_3", "Story Event Choice 3");
                    #region Functionality

                    #endregion
                    print("Story Load");
                    break;
            }
            


        }

        //EXECUTE THE DETAILS FROM THE STORED VALUES
        void ExecuteStoryDialogue()
        {
            print("Story Execute");
            // IF CHOICE #1 IS MADE
            if (DialogueLua.GetVariable(("Quest_Story_EventChosen")).asInt == 1)
            {
                print("Story Choice #1");

                DialogueLua.SetVariable(("Quest_Story_EventChosen"), 0);
                Disable();
                EventChosen = true;
                isEvent = false;

                DayScore_1 += 1;
                storyDay++;
                print("Story Day = " + storyDay);
                print("Day Score=" + DayScore_1);

            }
            // IF CHOICE #2 IS MADE
            if (DialogueLua.GetVariable(("Quest_Story_EventChosen")).asInt == 2)
            {
                print("Story Choice #2");

                DialogueLua.SetVariable(("Quest_Story_EventChosen"), 0);
                EventChosen = true;
                isEvent = false;

                DayScore_1 += 0;
                storyDay++;
                print("Story Day = " + storyDay);
                print("Day Score=" + DayScore_1);

            }
            // IF CHOICE #3 IS MADE
            if (DialogueLua.GetVariable(("Quest_Story_EventChosen")).asInt == 3)
            {
                print("Story Choice #3");

                DialogueLua.SetVariable(("Quest_Story_EventChosen"), 0);
                EventChosen = true;
                isEvent = false;


                DayScore_1 -= 1;
                storyDay++;
                print("Story Day = " + storyDay);
                print("Day Score=" + DayScore_1);
            }
        }

    }
}