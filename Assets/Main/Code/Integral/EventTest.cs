using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    /// <summary>
    ///isSeason checks whether a new season has started
    ///Day is the current day numner
    ///NONseason events_days are what day the non season minor events will happen.
    ///EventTitle_Minor_Name is the name that is assigned to the event
    /// </summary>
    public bool isSeason = true;
    public int Day = 1;

    //THESE ARE ALL MINOR EVENTS
    public int NONSEASON_Event_01_day;
    public int NONSEASON_Event_02_day;
    public int NONSEASON_Event_03_day;
    public int NONSEASON_Event_04_day;

    public int NONSEASON_Event_01_MAJOR_Day;
    
    string EventTitle_Minor_Name;
    string EventTitle_Major_Name;

    //Seasons go in order. Start with Summer (1), then Autumn (2) then Winter (3) then Spring (4).
    int SeasonNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Season starts in Summer
        SeasonNumber = 1;
        PrintSeasonName();
        //print the current day which is 1
        print(Day);
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
    //You click to add a day
        if (Input.GetMouseButtonDown(0))
        {
            
            Day = Day + 1;
            print(Day);
            //if the day matches one of the randomly chosen event days, the event will happen

            /////////////////////////////////////////////////////////////////////////////////
            //THIS IS ONLY FOR MINOR EVENTS. 1-4
            ////////////////////////////////////////////////////////////////////////////////
            if(Day == NONSEASON_Event_01_day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_02_day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_03_day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(EventTitle_Minor_Name);
            }
            if (Day == NONSEASON_Event_04_day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MINOR EVENT");
                NONSEASON_ChooseEvent_Minor();
                print(EventTitle_Minor_Name);
            }

            /////////////////////////////////////////////////////////////////////////////////
            //THIS IS ONLY FOR MAJOR EVENTS. ONLY ONE PER SEASON
            ////////////////////////////////////////////////////////////////////////////////
            if (Day == NONSEASON_Event_01_MAJOR_Day)
            {
                //This is where it calls the function that choosen a random minor event
                print("MAJOR EVENT");
                NONSEASON_ChooseEvent_Major();
                print(EventTitle_Major_Name);
            }
        }
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
        //randomly choose a day within the season for each event
        NONSEASON_Event_01_day = (int)Random.Range(1,90);
        NONSEASON_Event_02_day = (int)Random.Range(1, 90);
        NONSEASON_Event_03_day = (int)Random.Range(1, 90);
        NONSEASON_Event_04_day = (int)Random.Range(1, 90);

        //randomly chooses a major event
        NONSEASON_Event_01_MAJOR_Day = (int)Random.Range(1, 90);

        //this tells the editor what event happens on what day
        print("NON SEASON RELATED: MINOR EVENT DAYS " + NONSEASON_Event_01_day.ToString() + " " + NONSEASON_Event_02_day.ToString() + " " + NONSEASON_Event_03_day.ToString() + " " + NONSEASON_Event_04_day.ToString() + " ");
        print("NON SEASON RELATED: MAJOR EVENT DAY " + NONSEASON_Event_01_MAJOR_Day.ToString());
    }

    //if a minor event day occurs, this chooses the minor event
    void NONSEASON_ChooseEvent_Minor()
    {
        //I am only using 3 choices but we can expand this to however many we want
        int RandomNumGen = (int)Random.Range(1, 3.99f);
        switch(RandomNumGen)
        {
            case 1:
                EventTitle_Minor_Name = "Minor NonSeason Event 1 Name";
                break;
            case 2:
                EventTitle_Minor_Name = "Minor NonSeason Event 2 Name";
                break;
            case 3:
                EventTitle_Minor_Name = "Minor NonSeason Event 3 Name";
                break;
        }
         
    }
    //if a major event day occurs, this chooses the minor event
    void NONSEASON_ChooseEvent_Major()
    {
        //I am only using 3 choices but we can expand this to however many we want
        int RandomNumGen = (int)Random.Range(1, 3.99f);
        switch (RandomNumGen)
        {
            case 1:
                EventTitle_Major_Name = "Major NonSeason Event 1 Name";
                break;
            case 2:
                EventTitle_Major_Name = "Major NonSeason Event 2 Name";
                break;
            case 3:
                EventTitle_Major_Name = "Major NonSeason Event 3 Name";
                break;
        }

    }
}
