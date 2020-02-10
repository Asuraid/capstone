using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI_Test : MonoBehaviour
{
    // Popup text counter.
    private static Floating_Text popupTextPositivePrefab;
    private static GameObject popupCanvas;

    // Day counter.
    public TextMeshPro Text_SeasonCount;
    public TextMeshPro Text_DayCount;
    public TextMeshPro Text_HourCount;

    // Resource counter.
    public TextMeshPro Text_RawGameCount;
    public TextMeshPro Text_RawFishCount;
    public TextMeshPro Text_CookedGameCount;
    public TextMeshPro Text_CookedFishCount;
    public EventTest eventTest;
    public ResourcesList resourcesList;
    
    public TextMeshPro Text_FoodSupply;

    // Villager counter.
    public VillagerManager villagerManager;
    public TextMeshPro Text_VillagerCount;
    public TextMeshPro Text_VillagerHappiness;
    public TextMeshPro Text_HuntingProductivity;
    public TextMeshPro Text_FishingProductivity;
    public TextMeshPro Text_CookingProductivity;
    // Start is called before the first frame update
    void Start()
    {
        // Needs replacing because fuck using find.
        popupCanvas = GameObject.Find("Popup Canvas");

        InitializePositive();
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
        Text_DayCount.text = "Days: " + eventTest.Day.ToString() + "/25";
        /////////////////////////////////////////////
        //DISPLAY HOUR
        Text_HourCount.text = "Hours: " + eventTest.hour.ToString() + "/10";

        ////////////////////////////////////////////////////////////////////////////////////////////
        /// Resources
        Text_RawFishCount.text = resourcesList.rawFish.ToString();
        Text_RawGameCount.text = resourcesList.rawGame.ToString();
        Text_CookedFishCount.text = resourcesList.Fish_Cooked.ToString();
        Text_CookedGameCount.text = resourcesList.Game_Cooked.ToString();

        Text_FoodSupply.text = resourcesList.FoodSupply.ToString();

        ////////////////////////////////////////////////////////////////////////////////////////////
        /// Villagers
        Text_VillagerCount.text =  villagerManager.villagerARRAY.Count.ToString();
        Text_VillagerHappiness.text = (villagerManager.averageHappiness / 2) * 100 + "%";
        Text_HuntingProductivity.text = "HuntingAVG: " + villagerManager.huntingAverage.ToString();
        Text_FishingProductivity.text = "FishingAVG: " + villagerManager.fishingAverage.ToString();
        Text_CookingProductivity.text = "CookingAVG: " + villagerManager.cookingAverage.ToString();


    }

    /// <summary>
    /// Initialize the positive text parent object using the folder location.
    /// </summary>
    public static void InitializePositive()
    {
        if (!popupTextPositivePrefab)
            popupTextPositivePrefab = Resources.Load<Floating_Text>("Assets/UI/Popup_Text_Parent_Positive");
    }

    /// <summary>
    /// Instantiate the floating text.
    /// </summary>
    /// <param name="text">Text to be added to the text object.</param>
    /// <param name="location">Location to tbe initiated.</param>
    public static void CreateFloatingTextPositive(string text, Transform location)
    {
        //Floating_Text instance = Instantiate(popupTextPositivePrefab);

        //instance.transform.SetParent(popupCanvas.transform, false);
        //instance.SetText(text);
    }
}
