using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    /// <summary>
    ///isSeason checks whether a new season has started
    ///Day is the current day numner
    //////Hour is the amount of hours used up. There are 10 hours in a day
    ///NONseason events_days are what day the non season minor events will happen.
    ///EventTitle_Minor_Name is the name that is assigned to the event
    /// </summary>
    public bool isSeason = true;
    public int Day = 1;
    public int hour = 0;

    /////////////////////////////////
    /// NON SEASON RELATED
    /////////////////////////////////
    
    //THESE ARE ALL NON SEASON RELATED MINOR EVENTS VARIABLES
    string NONSEASON_EventTitle_Minor_Name;
    //Sets up array for non season related minor events
    public int howmanyNONSEASON_MinorEvents = 0;
    int[] NONSEASON_Event_day = new int[4] { 0, 0, 0, 0 };
    //THESE ARE ALL NON SEASON RELATED MAJOR EVENTS VARIABLES
    public int NONSEASON_Event_01_MAJOR_Day;
    string NONSEASON_EventTitle_Major_Name;

    /////////////////////////////////
    /// SEASON RELATED
    /////////////////////////////////

    //THESE ARE ALL SEASON RELATED MINOR EVENTS VARIABLES
    string SEASON_EventTitle_Minor_Name;
    //Sets up array for season related minor events
    public int howmanySEASON_MinorEvents = 0;
    int[] SEASON_Event_day = new int[4] { 0, 0, 0, 0 };
    //THESE ARE ALL SEASON RELATED MAJOR EVENTS VARIABLES
    public int SEASON_Event_01_MAJOR_Day;
    string SEASON_EventTitle_Major_Name;


    //Seasons go in order. Start with Summer (1), then Autumn (2) then Winter (3) then Spring (4).
    public int SeasonNumber = 1;


    /////////////////////////////////
    /// Unique/NPC Events
    /////////////////////////////////
    
    //THESE ARE ALL Unique  MINOR EVENTS VARIABLES
    string UNIQUE_EventTitle_Name;
    //Sets up array for unique  minor events
    public int howmanyUNIQUE_MinorEvents = 0;
    public int UNIQUE_Event_01_Day;

    // Start is called before the first frame update
    void Start()
    {

    //Season starts in Summer
    SeasonNumber = 1;
        PrintSeasonName();
        //print the current day which is 1
        print("Day: " + Day);
    }

    // Update is called once per frame
    void Update()
        //is the day has reached the end of the season, reset the season
    { if (Day > 90)
        {
            isSeason = true;
            SeasonNumber = SeasonNumber + 1;
            PrintSeasonName();
            Day = 1;
            print(Day);
        }
    //You click to add a day // GOT RID OF THIS
      //  if (Input.GetMouseButtonDown(0))
      //  {
            //THERE IS NOW A FUNCTION FOR ADDING A DAY

        //This changes the day if the hours are used up
        if (hour >= 10)
        {
            hour = 0;
            AddaDay();
        }


            //if the day matches one of the randomly chosen event days, the event will happen

            ///////////////////////////////////////////////////////////////////////////////////
            /// NON SEASON RELATED
            ///////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////
            //THIS IS ONLY FOR MINOR EVENTS. 1-4
            /////////////////////////////////////
            if (Day == NONSEASON_Event_day[0])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(NONSEASON_EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_day[1])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(NONSEASON_EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_day[2])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(NONSEASON_EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_day[3])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(NONSEASON_EventTitle_Minor_Name);
            }

            /////////////////////////////////////////////////////
            //THIS IS ONLY FOR MAJOR EVENTS. ONLY ONE PER SEASON
            /////////////////////////////////////////////////////
            if (Day == NONSEASON_Event_01_MAJOR_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MAJOR EVENT");
                NONSEASON_ChooseEvent_Major();
                print(NONSEASON_EventTitle_Major_Name);
            }

            ///////////////////////////////////////////////////////////////////////////////////
            /// SEASON RELATED
            ///////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////
            //THIS IS ONLY FOR MINOR EVENTS. 1-4
            /////////////////////////////////////
            if (Day == SEASON_Event_day[0])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                SEASON_ChooseEvent_Minor();
                print(SEASON_EventTitle_Minor_Name);
            }
            if (Day == SEASON_Event_day[1])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                SEASON_ChooseEvent_Minor();
                print(SEASON_EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_day[2])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                SEASON_ChooseEvent_Minor();
                print(SEASON_EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_day[3])
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                SEASON_ChooseEvent_Minor();
                print(SEASON_EventTitle_Minor_Name);
            }

            /////////////////////////////////////////////////////
            //THIS IS ONLY FOR MAJOR EVENTS. ONLY ONE PER SEASON
            /////////////////////////////////////////////////////
            if (Day == NONSEASON_Event_01_MAJOR_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MAJOR EVENT");
                SEASON_ChooseEvent_Major();
                print(SEASON_EventTitle_Major_Name);
            }

            ///////////////////////////////////////////////////////////////////////////////////
            /// UNIQUE EVENTS
            ///////////////////////////////////////////////////////////////////////////////////

            if (Day == UNIQUE_Event_01_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                UNIQUE_ChooseEvent_Minor();
                print(UNIQUE_EventTitle_Name);
            }
            if (Day == UNIQUE_Event_01_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                UNIQUE_ChooseEvent_Minor();
                print(UNIQUE_EventTitle_Name);
            }
            if (Day == UNIQUE_Event_01_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                UNIQUE_ChooseEvent_Minor();
                print(UNIQUE_EventTitle_Name);
            }
            if (Day == UNIQUE_Event_01_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                UNIQUE_ChooseEvent_Minor();
                print(UNIQUE_EventTitle_Name);
            }

       // }
        if (isSeason)
        {
            //if the season changes, reset all the values
            
            InstantiateEventValues();
            isSeason = false;
        }
    }
    void PrintSeasonName()
    {
        switch (SeasonNumber)
        {
            case 1:
                print("Summer Season");
                break;
            case 2:
                print("Autumn Season");
                break;
            case 3:
                print("Winter Season");
                break;
            case 4:
                print("Spring Season");
                break;
        }
    }


    //this only happens at the start of each season
    void InstantiateEventValues()
    {
        //randomly choses how many random non season related events will happen
        howmanyNONSEASON_MinorEvents = (int)Random.Range(1, 4.99f);
        //randomly choses how many random  season related events will happen
        howmanySEASON_MinorEvents = (int)Random.Range(1, 4.99f);

        //RESETS all of the previous season's event days to 0. The day will NEVER reach 0
        NONSEASON_Event_day[0] = 0;
        NONSEASON_Event_day[1] = 0;
        NONSEASON_Event_day[2] = 0;
        NONSEASON_Event_day[3] = 0;
        //randomly choose a day within the season for each MINOR NON SEASON event

        ///NON SEASON RELATED
        for (int i = 0; i < howmanyNONSEASON_MinorEvents; i++)
        {
            NONSEASON_Event_day[i] = (int)Random.Range(1, 90);
        }
        
        //randomly chooses a major event
        NONSEASON_Event_01_MAJOR_Day = (int)Random.Range(1, 90);

        //SEASON RELATED
        for (int i = 0; i < howmanySEASON_MinorEvents; i++)
        {
            SEASON_Event_day[i] = (int)Random.Range(1, 90);
        }

        //randomly chooses a major event
        SEASON_Event_01_MAJOR_Day = (int)Random.Range(1, 90);

        //Decides if there will be a unique event

        int randomuniqueeventdecider = (int)(Random.Range(1, 2.99f));
        if (randomuniqueeventdecider == 1)
        {
            UNIQUE_Event_01_Day = (int)Random.Range(1, 90);
        }


        //this tells the editor what event happens on what day
        print("NON SEASON RELATED: MINOR EVENT DAYS " + NONSEASON_Event_day[0].ToString() + " " + NONSEASON_Event_day[1].ToString() + " " + NONSEASON_Event_day[2].ToString() + " " + NONSEASON_Event_day[3].ToString() + " ");
        print("NON SEASON RELATED: MAJOR EVENT DAY " + NONSEASON_Event_01_MAJOR_Day.ToString());
        print("SEASON RELATED: MINOR EVENT DAYS " + SEASON_Event_day[0].ToString() + " " + SEASON_Event_day[1].ToString() + " " + SEASON_Event_day[2].ToString() + " " + SEASON_Event_day[3].ToString() + " ");
        print("SEASON RELATED: MAJOR EVENT DAY " + SEASON_Event_01_MAJOR_Day.ToString());
        print("UNIQUE EVENT DAY " + UNIQUE_Event_01_Day.ToString());
    }


    /// //////////////////////////////////////////////////////////////////
    /// Non Season Related
    /// //////////////////////////////////////////////////////////////////


    //if a minor event day occurs, this chooses the minor event
    void NONSEASON_ChooseEvent_Minor()
    {
        //I am only using 3 choices but we can expand this to however many we want
        int RandomNumGen = (int)Random.Range(1, 5.99f);
        switch(RandomNumGen)
        {
            case 1:
                NONSEASON_EventTitle_Minor_Name = "Minor NonSeason Event 1 Name";
                break;
            case 2:
                NONSEASON_EventTitle_Minor_Name = "Minor NonSeason Event 2 Name";
                break;
            case 3:
                NONSEASON_EventTitle_Minor_Name = "Minor NonSeason Event 3 Name";
                break;
            case 4:
                NONSEASON_EventTitle_Minor_Name = "Minor NonSeason Event 4 Name";
                break;
            case 5:
                NONSEASON_EventTitle_Minor_Name = "Minor NonSeason Event 5 Name";
                break;
        }
         
    }
    //if a major event day occurs, this chooses the minor event
    void NONSEASON_ChooseEvent_Major()
    {
        //I am only using 3 choices but we can expand this to however many we want
        int RandomNumGen = (int)Random.Range(1, 5.99f);
        switch (RandomNumGen)
        {
            case 1:
                NONSEASON_EventTitle_Major_Name = "Major NonSeason Event 1 Name";
                break;
            case 2:
                NONSEASON_EventTitle_Major_Name = "Major NonSeason Event 2 Name";
                break;
            case 3:
                NONSEASON_EventTitle_Major_Name = "Major NonSeason Event 3 Name";
                break;
            case 4:
                NONSEASON_EventTitle_Major_Name = "Major NonSeason Event 4 Name";
                break;
            case 5:
                NONSEASON_EventTitle_Major_Name = "Major NonSeason Event 5 Name";
                break;

        }

    }
    /// //////////////////////////////////////////////////////////////////
    /// Season Related
    /// //////////////////////////////////////////////////////////////////
    /// 

    //if a minor event day occurs, this chooses the minor event
    void SEASON_ChooseEvent_Minor()
    {
        int RandomNumGen = (int)Random.Range(1, 5.99f);
        switch (SeasonNumber) {
    
            //SUMMER
            case 1:
        //I am only using 3 choices but we can expand this to however many we want
     
        switch (RandomNumGen)
        {
            case 1:
                SEASON_EventTitle_Minor_Name = "Minor Summer Season Event 1 Name";
                break;
            case 2:
                SEASON_EventTitle_Minor_Name = "Minor Summer Season Event 2 Name";
                break;
            case 3:
                SEASON_EventTitle_Minor_Name = "Minor Summer Season Event 3 Name";
                break;
            case 4:
                SEASON_EventTitle_Minor_Name = "Minor Summer Season Event 4 Name";
                break;
            case 5:
                SEASON_EventTitle_Minor_Name = "Minor Summer Season Event 5 Name";
                break;
        }
                break;
            //AUTUMN
            case 2:
                //I am only using 3 choices but we can expand this to however many we want
 
                switch (RandomNumGen)
                {
                    case 1:
                        SEASON_EventTitle_Minor_Name = "Minor Autumn Season Event 1 Name";
                        break;
                    case 2:
                        SEASON_EventTitle_Minor_Name = "Minor Autumn Season Event 2 Name";
                        break;
                    case 3:
                        SEASON_EventTitle_Minor_Name = "Minor Autumn Season Event 3 Name";
                        break;
                    case 4:
                        SEASON_EventTitle_Minor_Name = "Minor Autumn Season Event 4 Name";
                        break;
                    case 5:
                        SEASON_EventTitle_Minor_Name = "Minor Autumn Season Event 5 Name";
                        break;
                }
                break;
            //WINTER
            case 3:
                //I am only using 3 choices but we can expand this to however many we want
           
                switch (RandomNumGen)
                {
                    case 1:
                        SEASON_EventTitle_Minor_Name = "Minor Winter Season Event 1 Name";
                        break;
                    case 2:
                        SEASON_EventTitle_Minor_Name = "Minor Winter Season Event 2 Name";
                        break;
                    case 3:
                        SEASON_EventTitle_Minor_Name = "Minor Winter Season Event 3 Name";
                        break;
                    case 4:
                        SEASON_EventTitle_Minor_Name = "Minor Winter Season Event 4 Name";
                        break;
                    case 5:
                        SEASON_EventTitle_Minor_Name = "Minor Winter Season Event 5 Name";
                        break;
                }
                break;
            //SPRING
            case 4:
                //I am only using 3 choices but we can expand this to however many we want
         
                switch (RandomNumGen)
                {
                    case 1:
                        SEASON_EventTitle_Minor_Name = "Minor Spring Season Event 1 Name";
                        break;
                    case 2:
                        SEASON_EventTitle_Minor_Name = "Minor Spring Season Event 2 Name";
                        break;
                    case 3:
                        SEASON_EventTitle_Minor_Name = "Minor Spring Season Event 3 Name";
                        break;
                    case 4:
                        SEASON_EventTitle_Minor_Name = "Minor Spring Season Event 4 Name";
                        break;
                    case 5:
                        SEASON_EventTitle_Minor_Name = "Minor Spring Season Event 5 Name";
                        break;
                }
                break;
        }

    }
    //if a major event day occurs, this chooses the minor event
    void SEASON_ChooseEvent_Major()
    {
        int RandomNumGen = (int)Random.Range(1, 5.99f);
        switch (SeasonNumber) {
            //I am only using 3 choices but we can expand this to however many we want
            //SUMMER
            case 1:
        switch (RandomNumGen)
        {
             
            case 1:
                SEASON_EventTitle_Major_Name = "Major Summer Season Event 1 Name";
                break;
            case 2:
                SEASON_EventTitle_Major_Name = "Major Summer Season Event 2 Name";
                break;
            case 3:
                SEASON_EventTitle_Major_Name = "Major Summer Season Event 3 Name";
                break;
            case 4:
                SEASON_EventTitle_Major_Name = "Major Summer Season Event 4 Name";
                break;
            case 5:
                SEASON_EventTitle_Major_Name = "Major Summer Season Event 5 Name";
                break;

        }
                break;
            //AUTUMN
            case 2:
                switch (RandomNumGen)
                {

                    case 1:
                        SEASON_EventTitle_Major_Name = "Major Autumn Season Event 1 Name";
                        break;
                    case 2:
                        SEASON_EventTitle_Major_Name = "Major Autumn Season Event 2 Name";
                        break;
                    case 3:
                        SEASON_EventTitle_Major_Name = "Major Autumn Season Event 3 Name";
                        break;
                    case 4:
                        SEASON_EventTitle_Major_Name = "Major Autumn Season Event 4 Name";
                        break;
                    case 5:
                        SEASON_EventTitle_Major_Name = "Major Autumn Season Event 5 Name";
                        break;

                }
                break;
            //WINTER
            case 3:
                switch (RandomNumGen)
                {

                    case 1:
                        SEASON_EventTitle_Major_Name = "Major Winter Season Event 1 Name";
                        break;
                    case 2:
                        SEASON_EventTitle_Major_Name = "Major Winter Season Event 2 Name";
                        break;
                    case 3:
                        SEASON_EventTitle_Major_Name = "Major Winter Season Event 3 Name";
                        break;
                    case 4:
                        SEASON_EventTitle_Major_Name = "Major Winter Season Event 4 Name";
                        break;
                    case 5:
                        SEASON_EventTitle_Major_Name = "Major Winter Season Event 5 Name";
                        break;

                }
                break;
            //SPRING
            case 4:
                switch (RandomNumGen)
                {

                    case 1:
                        SEASON_EventTitle_Major_Name = "Major Spring Season Event 1 Name";
                        break;
                    case 2:
                        SEASON_EventTitle_Major_Name = "Major Spring Season Event 2 Name";
                        break;
                    case 3:
                        SEASON_EventTitle_Major_Name = "Major Spring Season Event 3 Name";
                        break;
                    case 4:
                        SEASON_EventTitle_Major_Name = "Major Spring Season Event 4 Name";
                        break;
                    case 5:
                        SEASON_EventTitle_Major_Name = "Major Spring Season Event 5 Name";
                        break;

                }
                break;
        }



    }
    void UNIQUE_ChooseEvent_Minor()
    {
        //I am only using 3 choices but we can expand this to however many we want
        int RandomNumGen = (int)Random.Range(1, 5.99f);
        switch (RandomNumGen)
        {
            case 1:
                UNIQUE_EventTitle_Name = "UNIQUE NonSeason Event 1 Name";
                break;
            case 2:
                UNIQUE_EventTitle_Name = "UNIQUE NonSeason Event 2 Name";
                break;
            case 3:
                UNIQUE_EventTitle_Name = "UNIQUE NonSeason Event 3 Name";
                break;
            case 4:
                UNIQUE_EventTitle_Name = "UNIQUE NonSeason Event 4 Name";
                break;
            case 5:
                UNIQUE_EventTitle_Name = "UNIQUE NonSeason Event 5 Name";
                break;
        }

    }
   public void AddaDay()
    {
        hour = 0;
        Day = Day + 1;
        print(Day);
    }
}
