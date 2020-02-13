using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Villager_AssignJob_FromUI : MonoBehaviour
{
    [Header("Villager Information")]
    public GameObject VillagerInformation;
    public GameObject[] VillagersArray;
    public GameObject[] VillagersLists_UI_Array;

    public Villager_Prefab[] villagerPrefab;

    [Header("Dropdown Information")]
    public GameObject[] dropdownArray;
    public TMP_Dropdown[] dropdownObjects;

    //public GameObject Dropdown_1;
    //public GameObject Dropdown_2;
    //public GameObject Dropdown_3;

    // Start is called before the first frame update

    private void Awake()
    {
        //Dropdown_1.GetComponent<TMP_Dropdown>().onValueChanged.AddListener(ChangeJob);
    }

    void Start()
    {
        VillagersArray = GameObject.FindGameObjectsWithTag("Villager");
        villagerPrefab = new Villager_Prefab[VillagersArray.Length];

        dropdownArray = GameObject.FindGameObjectsWithTag("Dropdown");

        SetVillagerList();

        SetUpVillagerPrefabs();

        SetUpDropdowns();
    }

    void SetVillagerList()
    {
        for (int i = 0; i < VillagersLists_UI_Array.Length;i++)
        {
            VillagersLists_UI_Array[i].transform.GetChild(1).GetChild(0).GetComponent<TextMeshPro>().text = VillagersArray[i].gameObject.name ;
        }
    }

    void SetUpVillagerPrefabs()
    {
        for (int i = 0; i < VillagersArray.Length; i++)
        {
            villagerPrefab[i] = VillagersArray[i].GetComponent<Villager_Prefab>();
        }
    }

    void SetUpDropdowns()
    {
        dropdownObjects = new TMP_Dropdown[dropdownArray.Length];

        for (int i = 0; i < dropdownArray.Length; i++)
        {
            dropdownObjects[i] = dropdownArray[i].GetComponent<TMP_Dropdown>();
            dropdownObjects[i].onValueChanged.AddListener(ChangeJob);
        }
    }

    void RunThingToHunter()
    {
        for (int i = 0; i < dropdownArray.Length; i++)
        {
            villagerPrefab[i].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Hunting);
        }
    }

    void RunThingToFisher()
    {
        for (int i = 0; i < dropdownArray.Length; i++)
        {
            villagerPrefab[i].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Fishing);
            print(villagerPrefab[i].WHATJOBDOIHAVE);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (VillagerInformation.activeSelf != true)
        {
            DisplayJobName();
        }
    }

    public void ChangeJob(int arg)
    {
        print(arg);

        if (arg == 0)
        {
            print("change to hunter");
            RunThingToHunter();
        }
        else if (arg == 1)
        {
            print("change to fisher");
            RunThingToFisher();
        }
        else if (arg == 2)
        {
            //print("change to cook");
            //villagerPrefab[0].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Cooking);
        }
        else
        {
            //print("change to no job");
            //villagerPrefab[0].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.None);
        }



        //if (Dropdown_2.GetComponent<TMP_Dropdown>().value == 0)
        //{
        //    villagerPrefab[1].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Hunting);
        //}
        //else if (Dropdown_2.GetComponent<TMP_Dropdown>().value == 1)
        //{
        //    villagerPrefab[1].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Fishing);
        //}
        //else if (Dropdown_2.GetComponent<TMP_Dropdown>().value == 2)
        //{
        //    villagerPrefab[1].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Cooking);
        //}
        //else
        //{
        //    villagerPrefab[1].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.None);
        //}



        //if (Dropdown_3.GetComponent<TMP_Dropdown>().value == 0)
        //{
        //    villagerPrefab[2].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Hunting);
        //}
        //else if (Dropdown_3.GetComponent<TMP_Dropdown>().value == 1)
        //{
        //    villagerPrefab[2].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Fishing);
        //}
        //else if (Dropdown_3.GetComponent<TMP_Dropdown>().value == 2)
        //{
        //    villagerPrefab[2].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.Cooking);
        //}
        //else
        //{
        //    villagerPrefab[2].AdjustJob(Villager_Prefab.WhatJobDoTheyHave.None);
        //}

        //switch (Dropdown_1.GetComponent<TMP_Dropdown>().value)
        //{
        //    //hunt
        //    case 0:
        //        VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Hunting;
        //        VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();

        //        break;
        //    //fish
        //    case 1:
        //        VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Fishing;
        //        VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //    //cook
        //    case 2:
        //        VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Cooking;
        //        VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //    //none
        //    case 3:
        //        VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.None;
        //        VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //}


        //switch (Dropdown_2.GetComponent<TMP_Dropdown>().value)
        //{
        //    //hunt
        //    case 0:
        //        VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Hunting;
        //        VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();

        //        break;
        //    //fish
        //    case 1:
        //        VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Fishing;
        //        VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //    //cook
        //    case 2:
        //        VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Cooking;
        //        VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //    //none
        //    case 3:
        //        VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.None;
        //        VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //}

        //switch (Dropdown_3.GetComponent<TMP_Dropdown>().value)
        //{
        //    //hunt
        //    case 0:
        //        VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Hunting;
        //        VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();

        //        break;
        //    //fish
        //    case 1:
        //        VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Fishing;
        //        VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //    //cook
        //    case 2:
        //        VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Cooking;
        //        VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //    //none
        //    case 3:
        //        VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.None;
        //        VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();
        //        break;
        //}

    }
    public void DisplayJobName()
    {
        //switch (VillagersArray[0].GetComponent<Villager_Prefab>().currentJob)
        //{
        //    case Villager_Prefab.WhatJobDoTheyHave.Hunting:
        //        Dropdown_1.GetComponent<TMP_Dropdown>().value = 0;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.Fishing:
        //        Dropdown_1.GetComponent<TMP_Dropdown>().value = 1;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.Cooking:
        //        Dropdown_1.GetComponent<TMP_Dropdown>().value = 2;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.None:
        //        Dropdown_1.GetComponent<TMP_Dropdown>().value = 3;
        //        break;
        //}
        //switch (VillagersArray[1].GetComponent<Villager_Prefab>().currentJob)
        //{
        //    case Villager_Prefab.WhatJobDoTheyHave.Hunting:
        //        Dropdown_2.GetComponent<TMP_Dropdown>().value = 0;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.Fishing:
        //        Dropdown_2.GetComponent<TMP_Dropdown>().value = 1;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.Cooking:
        //        Dropdown_2.GetComponent<TMP_Dropdown>().value = 2;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.None:
        //        Dropdown_2.GetComponent<TMP_Dropdown>().value = 3;
        //        break;
        //}
        //switch (VillagersArray[2].GetComponent<Villager_Prefab>().currentJob)
        //{
        //    case Villager_Prefab.WhatJobDoTheyHave.Hunting:
        //        Dropdown_3.GetComponent<TMP_Dropdown>().value = 0;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.Fishing:
        //        Dropdown_3.GetComponent<TMP_Dropdown>().value = 1;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.Cooking:
        //        Dropdown_3.GetComponent<TMP_Dropdown>().value = 2;
        //        break;
        //    case Villager_Prefab.WhatJobDoTheyHave.None:
        //        Dropdown_3.GetComponent<TMP_Dropdown>().value = 3;
        //        break;
        //}
    }
}
