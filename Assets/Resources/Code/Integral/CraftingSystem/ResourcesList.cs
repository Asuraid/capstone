using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesList : MonoBehaviour
{
    [Header("Event Tester")]
    //Direct reference to the event system. This is used to edit the hour count
    public EventTest eventTest;

    [Header("Villager Manager")]
    public VillagerManager villagerManager;
    //More villagers means that more resources will be taken
    int VillagerCount = 1;

    [Header("Temp")]
    // Very temporary location for fish raw text location.
    public GameObject rawFishText;

    //RESOURCES
    [Header("Raw Goods")]
    public int rawFish;
    public int rawGame;

    //CRAFTED GOODS
    [Header("Crafted Goods")]
    public int Fish_Cooked;
    public int Game_Cooked;

    //Buildings
    //FOOD
    [Header("Locations")]
    public GameObject Pond;
    public GameObject Forest;
    public GameObject Oven;

    [Header("Categories")]
    //Categories
    public int FoodSupply = 0;

    [Header("Hours")]
    //Hour Counter
    //As of now, each event takes 2 hours. There are 10 hours in a day. At the end of the day, different values will be calculated
    public int HourCount = 0;

    //How many resources are gathered
    int resources_gathered_fish = 0;
    int resources_gathered_cook = 0;
    int resources_gathered_hunter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //calculate number of villagers
        VillagerCount = villagerManager.villagerARRAY.Count;

        eventTest.hour = HourCount;

     if (HourCount >= 10)
        {
            eventTest.Action();

            HourCount = 0;
            EndOfDayCalculate();
        }   
    }

   public  void PrintInfo()
    {
        //print Information
     //   print("Raw Fish : " + rawFish + "," + "Cooked Fish : " + Fish_Cooked + "," + "Raw Game: " + rawGame + "," + "Cooked Game: " + Game_Cooked);
        //If oven doesnt exist yet
        if (Oven.activeSelf == false)
        {
      //      print ("You need to build an Oven! You can catch Fish but can't cook them!");
        }
    }

    void EndOfDayCalculate()
    {
        //Add up all sources of Food
        FoodSupply = Fish_Cooked + Game_Cooked;
        //Each villager needs to eat. So this number goes down for each villager
        FoodSupply = FoodSupply - VillagerCount;
        //PrintInfo();
        //print("Food Supply Left: " + FoodSupply);

        //if Food has run out
        if (FoodSupply <0)
        {
            print("You need to make more food! We have run out");
        }
    }

    public void VillagerWork()
    {

        //THIS IS WHERE WE CALCULATE HOW MUCH VILLAGERS GET FOR RESOURCE GATHERING

        //You take how many workers are assigned to that job.
        //Multiply that number times average productivity for that job
        //Multiply that final number times happiness amount
        //That is how many resources are gathered by doing that action


        //EXAMPLES NUMBERS:

        //1 villager who is good at their job and is at max happiness should produce 8 resources. (2 x 2 x 2)
        

        //FISHERMAN
        resources_gathered_fish = (int)(villagerManager.activeFishers * villagerManager.fishingAverage * villagerManager.averageHappiness);
        rawFish = rawFish + resources_gathered_fish;
        //HUNTERS
        resources_gathered_hunter = (int)(villagerManager.activeHunters * villagerManager.huntingAverage * villagerManager.averageHappiness);
        rawGame = rawGame + resources_gathered_hunter;
        //COOKS
        resources_gathered_cook = (int)(villagerManager.activeCooks * villagerManager.cookingAverage * villagerManager.averageHappiness);
        Fish_Cooked = Fish_Cooked + resources_gathered_cook;
        Game_Cooked = Game_Cooked + resources_gathered_cook;

        print(resources_gathered_fish);
        print(resources_gathered_hunter);
        print(resources_gathered_cook);
        resources_gathered_fish = 0;
        resources_gathered_cook = 0;
        resources_gathered_hunter = 0;



    }

    public virtual void AddRawFishResource(int amount)
    {
        rawFish += amount;
        TextUI_Test.CreateFloatingTextPositive(amount.ToString(), rawFishText.transform);
    }
}
