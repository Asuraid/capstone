using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Pathfinding;

public class Villager_Prefab : MonoBehaviour
{

    //WHAT DOES A VILLAGER NEED
    //A profession
    //A happiness ranking
    //A productivity number.0 = none. 1 = avg. 2= best
    //A job that they are assigned


    public enum WhatJobAreTheyGoodAt // your custom enumeration
    {
        None,
        Hunting,
        Woodcutting,
        Mining,
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
        Woodcutting,
        Mining,
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
    //1 = hunter. 2 = fisher. 3 = woodcutter. 4 = miner. 5 = cook.
    public int WHATJOBAMIGOODAT;
    [HideInInspector]
    //1 = hunter. 2 = fisher. 3 = woodcutter. 4 = miner. 5 = cook.
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

    [Header("Animator")]
    // Tied to animation, don't touch.
    public float animationActiveDistance;
    Animator animator;
    AIDestinationSetter aiDestination;
    AIPath aiPath;
    CharacterController controller;
    bool isMoving;
    bool isWorking;
    public GameObject axeObject;
    public GameObject fishingObject;
    Vector3 ogScale;

    [Header("Location Targets & Movement")]
    public Transform huntingTarget;
    public Transform fishTarget;
    public Transform woodTarget;
    public Transform mineTarget;
    public Transform homeTarget;
    public Transform cookingTarget;
    [Space(10)]
    public float movementSpeed = 1;

    [Header("Job Changing")]
    public GameObject infoContainer;
    TMP_Dropdown dropdown;

    private void Awake()
    {
        // Simple checks to see if certain things are not attached.
        if (animator == null)
            animator = GetComponent<Animator>();
        else
            print("There is no animator attached!");

        if (controller == null)
            controller = GetComponent<CharacterController>();
        else
            print("There is no controller attached!");

        if (aiDestination == null)
            aiDestination = GetComponent<AIDestinationSetter>();
        else
            print("There is no AI Destination attached!");

        if (aiPath == null)
            aiPath = GetComponent<AIPath>();
        else
            print("There is no AI Path attached!");

        if (dropdown == null)
            dropdown = infoContainer.GetComponentInChildren<TMP_Dropdown>();
        else
            print("There is no dropdown attached!");

        if (axeObject == null)
            print("There is no axe attached!");

        if (fishingObject == null)
            print("There is no axe attached!");

        // Set listener to dropdown to allow value changing.
        dropdown.onValueChanged.AddListener(AdjustDropdownJobs);

        // Set the job to none.
        dropdown.value = 3;

        // Save original scale.
        ogScale = transform.localScale;

        movementSpeed = aiPath.maxSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        //VM.villagerARRAY.Add(gameObject);
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

        //Set object to inactive.
        axeObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the villager is moving.
        if (controller.velocity != Vector3.zero)
        {
            bool isMoving = true;

            animator.SetBool("moving", isMoving);
        }

        // If the villager is not moving, switch to idle animation.
        if (controller.velocity == Vector3.zero)
        {
            bool isMoving = false;

            animator.SetBool("moving", isMoving);
        }

        if(aiPath.remainingDistance <= animationActiveDistance)
        {
            bool isWorking = true;
            axeObject.gameObject.SetActive(true);

            animator.SetBool("working", isWorking);
        } else
        {
            bool isWorking = false;
            axeObject.gameObject.SetActive(false);

            animator.SetBool("working", isWorking);
        }

        // These two functions control the direction the sprite is facing towards.
        if (controller.velocity.x > 0)
        {
            transform.localScale = new Vector3(-ogScale.x, ogScale.y, ogScale.z);
        }

        if (controller.velocity.x < 0)
        {
            transform.localScale = new Vector3(ogScale.x, ogScale.y, ogScale.z);
        }

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
    }

    public void PauseMovement()
    {
        aiPath.maxSpeed = 0;
    }

    public void ResumeMovement()
    {
        aiPath.maxSpeed = movementSpeed;
    }

    #region Job Adjustments
    public void AdjustDropdownJobs(int arg)
    {
        if (arg == 0)
        {
            ChangeToHunter();
        }
        else if (arg == 1)
        {
            ChangeToFisher();
        }
        else if (arg == 2)
        {
            ChangeToWoodcutter();
        }
        else if (arg == 3)
        {
            ChangeToMiner();
        }
        else if (arg == 4)
        {
            ChangeToCook();
        }
        else if (arg == 5)
        {
            ChangeToCook();
        }
        else
        {
            ChangeToNoJob();
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

    public void AdjustJob(WhatJobDoTheyHave jobs)
    {
        print("the job being fed in is" + jobs);
        currentJob = jobs;

        switch (currentJob)
        {
            case WhatJobDoTheyHave.None:
                ChangeToNoJob();
                break;
            case WhatJobDoTheyHave.Hunting:
                ChangeToHunter();
                break;
            case WhatJobDoTheyHave.Fishing:
                ChangeToFisher();
                break;
            case WhatJobDoTheyHave.Cooking:
                ChangeToCook();
                break;
            default:
                print("Something went wrong that it arrived to the default case.");
                break;
        }
    }

   public void ChangeToHunter()
    {
        WHATJOBDOIHAVE = 1;
        aiDestination.target = huntingTarget;
    }

    public void ChangeToFisher()
    {
        WHATJOBDOIHAVE = 2;
        aiDestination.target = fishTarget;
    }

    public void ChangeToWoodcutter()
    {
        WHATJOBDOIHAVE = 3;
        aiDestination.target = woodTarget;
    }

    public void ChangeToMiner()
    {
        WHATJOBDOIHAVE = 4;
        aiDestination.target = mineTarget;
    }

    public void ChangeToCook()
    {
        WHATJOBDOIHAVE = 5;
        aiDestination.target = cookingTarget;
    }

    public void ChangeToNoJob()
    {
        WHATJOBDOIHAVE = 0;
        aiDestination.target = homeTarget;
    }
    #endregion
}
