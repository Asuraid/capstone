using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI_Test : MonoBehaviour
{
    public TextMeshPro Text_SeasonCount;
    public TextMeshPro Text_DayCount;
    public TextMeshPro Text_HourCount;

    public TextMeshPro Text_RawGameCount;
    public TextMeshPro Text_RawFishCount;
    public TextMeshPro Text_CookedGameCount;
    public TextMeshPro Text_CookedFishCount;
    public EventTest eventTest;
    public ResourcesList resourcesList;
    public VillagerManager villagerManager;

    public TextMeshPro Text_FoodSupply;

    public TextMeshPro Text_VillagerCount;
    public TextMeshPro Text_VillagerHappiness;
    public TextMeshPro Text_HuntingProductivity;
    public TextMeshPro Text_FishingProductivity;
    public TextMeshPro Text_CookingProductivity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ////////////////////////////////////////////////////////////////////////////////////////////
        /// TIME

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
        Text_DayCount.text = eventTest.Day.ToString() + "/25";
        /////////////////////////////////////////////
        //DISPLAY HOUR
        Text_HourCount.text = eventTest.hour.ToString() + "/10";

        ////////////////////////////////////////////////////////////////////////////////////////////
        /// Resources
        Text_RawFishCount.text = "Raw Fish:"+ resourcesList.Fish_Raw.ToString();
        Text_RawGameCount.text = "Raw Game:"+ resourcesList.Game_Raw.ToString();
        Text_CookedFishCount.text = "Raw Fish:" + resourcesList.Fish_Cooked.ToString();
        Text_CookedGameCount.text = "Raw Game:" + resourcesList.Game_Cooked.ToString();

        Text_FoodSupply.text = resourcesList.FoodSupply.ToString();

        ////////////////////////////////////////////////////////////////////////////////////////////
        /// Villagers
        Text_VillagerCount.text =  villagerManager.villagerARRAY.Count.ToString();
        Text_VillagerHappiness.text = "Happiness: " + (villagerManager.happiness_avg / 2) * 100 + "%";
        Text_HuntingProductivity.text = "HuntingAVG: " + villagerManager.hunting_productivity_avg.ToString();
        Text_FishingProductivity.text = "FishingAVG: " + villagerManager.fishing_productivity_avg.ToString();
        Text_CookingProductivity.text = "CookingAVG: " + villagerManager.cooking_productivity_avg.ToString();


    }
}
