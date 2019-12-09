using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerManager : MonoBehaviour
{
    // Start is called before the first frame update

    //VILLAGERS PREFAB
    public List<GameObject> villagerARRAY = new List<GameObject>();

    [Header("Happiness")]
    //AVERAGE HAPPINESS
    public float averageHappiness;

    [Header("Productivity Averages")]
    //PRODUCTIVITY  IN EACH PROFESSION
    //There will be 3 professions right now: Hunter,Fisher, Cook
    //if a villager is assigned to this job, the productivity will go up
    public float huntingAverage = 0;
    public float fishingAverage = 0;
    public float cookingAverage = 0;

    [Header("Working Villagers")]
    //this is how many of each profession you have
    public int activeHunters;
    public int activeFishers;
    public int activeCooks;

    //these numbers are purely for mathematics. please don't touch them
     float happinessnumber;
    float huntingnumber;
     float fishingnumber;
     float cookingnumber;
    void Start()
    {
        //these numbers are purely for mathematics. please don't touch them
        happinessnumber = 0;
        huntingnumber = 0;
        fishingnumber = 0;
        cookingnumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //This goes through each villager in the world, and finds certain info about them
        for (int x = 0; x < villagerARRAY.Count;x++)
        {



            //this makes a number that adds up all of happiness from each villager
            happinessnumber = happinessnumber + villagerARRAY[x].GetComponent<Villager_Prefab>().individualHappiness;
            //this makes up a number that acts as how well your town is at each job



            huntingnumber = huntingnumber + villagerARRAY[x].GetComponent<Villager_Prefab>().hunting_productivity_individual;
            fishingnumber = fishingnumber + villagerARRAY[x].GetComponent<Villager_Prefab>().fishing_productivity_individual;
            cookingnumber = cookingnumber + villagerARRAY[x].GetComponent<Villager_Prefab>().cooking_productivity_individual;





            //COUNT HOW MANY OF EACH PROFESSION

            activeCooks = 0;
            activeFishers = 0;
            activeHunters = 0;
            if (villagerARRAY[x].GetComponent<Villager_Prefab>().WHATJOBDOIHAVE == 1)
            {
                activeHunters = activeHunters + 1;
            }
            if (villagerARRAY[x].GetComponent<Villager_Prefab>().WHATJOBDOIHAVE == 2)
            {
                activeFishers = activeFishers + 1;
            }
            if (villagerARRAY[x].GetComponent<Villager_Prefab>().WHATJOBDOIHAVE == 3)
            {
                activeCooks = activeCooks + 1;
            }

        }
        //We get a number average of the happiness in your town
        averageHappiness = happinessnumber / villagerARRAY.Count;
        //We get a number average of the efficiency of hunting in your town
        huntingAverage = huntingnumber / villagerARRAY.Count;
        //We get a number average of the efficiency of fishing in your town
        fishingAverage = fishingnumber / villagerARRAY.Count;
        //We get a number average of the efficiency of cooking in your town
        cookingAverage = cookingnumber / villagerARRAY.Count;

        //this resets the happiness number vairable
        happinessnumber = 0;
        huntingnumber = 0;
        fishingnumber = 0;
        cookingnumber = 0;

    }
}
