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

    public VillagerManager VM;
    //1 = hunter. 2 = fisher. 3 = cook
    public int WHATJOBAMIGOODAT;
    //1 = hunter. 2 = fisher. 3 = cook
    public int WHATJOBDOIHAVE;
    //how happy am i?
    //1 is normal
    public float happiness_individual;

    //THESE ARE PURELY FOR MATHEMATICS. PLEASE DONT TOUCH
     float hunting_number;
     float fishing_number;
     float cooking_number;


    //HOW GOOD THEY ARE AT EACH JOB
    public float hunting_productivity_individual;
    public float fishing_productivity_individual;
    public float cooking_productivity_individual;



    //UI. THIS CAN PROBABLY BE DELETED LATER
    public TextMeshPro profession;
    public TextMeshPro assignedjob;

    // Start is called before the first frame update
    void Start()
    {

        VM.villagerARRAY.Add(gameObject);
        //EVERYONE STARTS OUT AVERAGE HAPPY
        happiness_individual = 1;
        //ONLY FOR MATH. DONT TOUCH
        hunting_number = 1;
        fishing_number = 1;
        cooking_number = 1;
        //EVERYONE STARTS AVERAGE AT EACH JOB
        hunting_productivity_individual = 1;
       fishing_productivity_individual = 1;
       cooking_productivity_individual = 1;

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

        //EVERYONE DOES BETTER IF THEY ARE HAPPY AND DOES WORSE IF THEY ARE NOT
        hunting_productivity_individual = hunting_number * happiness_individual;
        fishing_productivity_individual = fishing_number * happiness_individual;
        cooking_productivity_individual = cooking_number * happiness_individual;




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
                assignedjob.text = "Job: Hunter";
                break;
            case 2:
                assignedjob.text = "Job: Fisher";
                break;
            case 3:
                assignedjob.text = "Job: Cook";
                break;
        }
    }
}
