using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI_Test : MonoBehaviour
{
    public TextMeshPro Text_SeasonCount;
    public TextMeshPro Text_DayCount;
    public TextMeshPro Text_HourCount;
    public EventTest eventTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DISPLAY SEASON
        switch (eventTest.SeasonNumber)
        {
            case 1:
                Text_SeasonCount.text = "Summer";
                break;
            case 2:
                Text_SeasonCount.text = "Autumn";
                break;
            case 3:
                Text_SeasonCount.text = "Winter";
                break;
            case 4:
                Text_SeasonCount.text = "Spring";
                break;
        }
        ////////////////////////////////////////////
        //DISPLAY DAY
        Text_DayCount.text = eventTest.Day.ToString() + "/90";
        /////////////////////////////////////////////
        //DISPLAY HOUR
        Text_HourCount.text = eventTest.hour.ToString() + "/10";
    }
}
