using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Villager_Prefab : MonoBehaviour
{

    //WHAT DOES A VILLAGER NEED
    //A profession
    //A happiness ranking
    //A productivity number.0 = none. 1 = avg. 2= best
    //A job that they are assigned


    // Dropdown menu for selecting jobs they are good at
    [Header("Villager Manager")]
    public VillagerManager VM;

    public enum WhatJobAreTheyGoodAt // your custom enumeration
    {
        None,
        Hunting,
        Fishing,
        Cooking
    };
    [Header("Job Related Attributes")]
    [Tooltip("What job they will excel in, giving extra resources when it matches up.")]
    public WhatJobAreTheyGoodAt jobProfession = WhatJobAreTheyGoodAt.None;  // this public var should appear as a drop down

    // Dropdown menu for selecting jobs
    public enum WhatJobDoTheyHave // your custom enumeration
    {
        None,
        Hunting,
        Fishing,
        Cooking
    };

    [Tooltip("What current job they are assigned to.")]
    public WhatJobDoTheyHave currentJob = WhatJobDoTheyHave.None;  // this public var should appear as a drop down

    //how happy am i?
    //1 is normal
    [Header("Villager Happiness")]
    [Range(0.0f, 2.0f)]
    [Tooltip("Happiness is on a range from 0-2, 1 is 50%.")]
    public float individualHappiness = 1;

    [HideInInspector]
    //1 = hunter. 2 = fisher. 3 = cook
    public int WHATJOBAMIGOODAT;
    [HideInInspector]
    //1 = hunter. 2 = fisher. 3 = cook
    public int WHATJOBDOIHAVE;
    

    //THESE ARE PURELY FOR MATHEMATICS. PLEASE DONT TOUCH
    float hunting_number;
     float fishing_number;
     float cooking_number;


    //HOW GOOD THEY ARE AT EACH JOB
    [HideInInspector]
    public float hunting_productivity_individual;
    [HideInInspector]
    public float fishing_productivity_individual;
    [HideInInspector]
    public float cooking_productivity_individual;


    [Header("UI Attributes")]
    //UI. THIS CAN PROBABLY BE DELETED LATER
    public GameObject UIBox;
    public TextMeshPro profession;
    public TextMeshPro assignedJob;

    // Start is called before the first frame update
    void Start()
    {

        VM.villagerARRAY.Add(gameObject);
        //EVERYONE STARTS OUT AVERAGE HAPPY
        individualHappiness = 1;
        //ONLY FOR MATH. DONT TOUCH
        hunting_number = 1;
        fishing_number = 1;
        cooking_number = 1;
        //EVERYONE STARTS AVERAGE AT EACH JOB
        hunting_productivity_individual = 1;
       fishing_productivity_individual = 1;
       cooking_productivity_individual = 1;

        //Check for jobs
        AdjustProfession();
        AdjustJob();

}

    // Update is called once per frame
    void Update()
    {


        //IF I AM ASSIGNED TO THE JOB I AM GOOD AT
        //I DO DOUBLE AS GOOD AS AVERAGE
        if (WHATJOBAMIGOODAT == WHATJOBDOIHAVE)
        {
            switch (WHATJOBDOIHAVE)
            {
                //hunting
                case 1:
                    hunting_number = 2;
                    break;
                //fishing
                case 2:
                    fishing_number = 2;
                    break;
                //cook
                case 3:
                    cooking_number = 2;
                    break;
            }
        }
        else
        {
            //if the villager is no longer assigned to a job they are good at, they remain average at that job
            hunting_number = 1;
            fishing_number = 1;
            cooking_number = 1;
        }

        //EVERYONE DOES BETTER IF THEY ARE HAPPY AND DOES WORSE IF THEY ARE NOT
        hunting_productivity_individual = hunting_number * individualHappiness;
        fishing_productivity_individual = fishing_number * individualHappiness;
        cooking_productivity_individual = cooking_number * individualHappiness;




        //UI. YOU CAN PROBABLY DELETE THIS AFTER
        switch (WHATJOBAMIGOODAT)
        {
            case 1:
                profession.text = "Profession: Hunter"; 
                break;
            case 2:
                profession.text = "Profession: Fisher";
                break;
            case 3:
                profession.text = "Profession: Cook";
                break;
        }
        switch (WHATJOBDOIHAVE)
        {
            case 1:
                assignedJob.text = "Job: Hunter";
                break;
            case 2:
                assignedJob.text = "Job: Fisher";
                break;
            case 3:
                assignedJob.text = "Job: Cook";
                break;
        }
    }

    void AdjustProfession()
    {
        switch (jobProfession)
        {
            case WhatJobAreTheyGoodAt.None:
                WHATJOBAMIGOODAT = 0;
                break;
            case WhatJobAreTheyGoodAt.Hunting:
                WHATJOBAMIGOODAT = 1;
                break;
            case WhatJobAreTheyGoodAt.Fishing:
                WHATJOBAMIGOODAT = 2;
                break;
            case WhatJobAreTheyGoodAt.Cooking:
                WHATJOBAMIGOODAT = 3;
                break;
            default:
                print("Something went wrong that it arrived to the default case.");
                break;
        }
    }

    void AdjustJob()
    {
        switch (currentJob)
        {
            case WhatJobDoTheyHave.None:
                WHATJOBDOIHAVE = 0;
                break;
            case WhatJobDoTheyHave.Hunting:
                WHATJOBDOIHAVE = 1;
                break;
            case WhatJobDoTheyHave.Fishing:
                WHATJOBDOIHAVE = 2;
                break;
            case WhatJobDoTheyHave.Cooking:
                WHATJOBDOIHAVE = 3;
                break;
            default:
                print("Something went wrong that it arrived to the default case.");
                break;
        }
    }

    void OnMouseEnter()
    {
        UIBox.SetActive(true);
    }

    void OnMouseExit()
    {
        UIBox.SetActive(false);
    }
}
