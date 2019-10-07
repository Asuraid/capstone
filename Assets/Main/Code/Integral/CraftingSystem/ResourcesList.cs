using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesList : MonoBehaviour
{
    //Direct reference to the event system. This is used to edit the hour count
    public EventTest eventTest;

    //RESOURCES
    public int Fish_Raw;
    public int Game_Raw;

    //CRAFTED GOODS
    public int Fish_Cooked;
    public int Game_Cooked;

    //Buildings
    //FOOD
    public GameObject Pond;
    public GameObject Forest;
    public GameObject Oven;

    //Categories
    public int FoodSupply = 0;

    //Hour Counter
    //As of now, each event takes 2 hours. There are 10 hours in a day. At the end of the day, different values will be calculated
    public int HourCount = 0;

    //Villagers Info
    //More villagers means that more resources will be taken
    int VillagerCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
     //   print("Raw Fish : " + Fish_Raw + "," + "Cooked Fish : " + Fish_Cooked + "," + "Raw Game: " + Game_Raw + "," + "Cooked Game: " + Game_Cooked);
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
}
