using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    int storyDay = 0;
    int storyMonth = 4;
    int month_1_score = 0;
    int overallScore = 0;
    int DayScore_1 = 0;
    bool isGame;


    // Start is called before the first frame update
    void Start()
    {
        print("Story Day = " + storyDay);
        print("Player Karma = " + overallScore);
    }

    // Update is called once per frame
    void Update()
    {
       if (storyMonth > 0) {
            isGame = true;
            if (Input.GetKeyDown(KeyCode.I))
            {
                storyDay += 1;
                DayScore_1 += 1;
                print("Story Day = " + storyDay);
                print("Day Score=" + DayScore_1);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                storyDay += 1;
                DayScore_1 += 0;
                print("Story Day = " + storyDay);
                print("Day Score=" + DayScore_1);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                storyDay += 1;
                DayScore_1 -= 1;
                print("Story Day = " + storyDay);
                print("Day Score=" + DayScore_1);
            }
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
     if (storyMonth <= 0)
        {
            if (isGame)
            {
                print("END" + "FINAL KARMA = " + overallScore);
                isGame = false;

   
            }
        }
        
    }


}
