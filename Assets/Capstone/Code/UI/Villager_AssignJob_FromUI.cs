using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Villager_AssignJob_FromUI : MonoBehaviour
{
    public GameObject VillagerInformation;
    public GameObject[] VillagersArray;
    public GameObject[] VillagersLists_UI_Array;
    public GameObject Dropdown_1;
    public GameObject Dropdown_2;
    public GameObject Dropdown_3;


    // Start is called before the first frame update


    void Start()
    {
    
         VillagersArray = GameObject.FindGameObjectsWithTag("Villager");
        SetVillagerList();
    }

    void SetVillagerList()
    {
        for (int i = 0; i < VillagersLists_UI_Array.Length;i++)
        {
          
            VillagersLists_UI_Array[i].transform.GetChild(1).GetChild(0).GetComponent<TextMeshPro>().text = VillagersArray[i].gameObject.name ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (VillagerInformation.activeSelf != true)
        {
            DisplayJobName();
        }

        ChangeJob();


    }
    public void ChangeJob()
    {

        
        switch (Dropdown_1.GetComponent<TMP_Dropdown>().value)
        {
            //hunt
            case 0:
                VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Hunting;
                VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
          
                break;
            //fish
            case 1:
                VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Fishing;
                VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
                break;
            //cook
            case 2:
                VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Cooking;
                VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
                break;
            //none
            case 3:
                VillagersArray[0].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.None;
                VillagersArray[0].GetComponent<Villager_Prefab>().AdjustJob();
                break;
        }


        switch (Dropdown_2.GetComponent<TMP_Dropdown>().value)
        {
            //hunt
            case 0:
                VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Hunting;
                VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();

                break;
            //fish
            case 1:
                VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Fishing;
                VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();
                break;
            //cook
            case 2:
                VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Cooking;
                VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();
                break;
            //none
            case 3:
                VillagersArray[1].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.None;
                VillagersArray[1].GetComponent<Villager_Prefab>().AdjustJob();
                break;
        }

        switch (Dropdown_3.GetComponent<TMP_Dropdown>().value)
        {
            //hunt
            case 0:
                VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Hunting;
                VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();

                break;
            //fish
            case 1:
                VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Fishing;
                VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();
                break;
            //cook
            case 2:
                VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.Cooking;
                VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();
                break;
            //none
            case 3:
                VillagersArray[2].GetComponent<Villager_Prefab>().currentJob = Villager_Prefab.WhatJobDoTheyHave.None;
                VillagersArray[2].GetComponent<Villager_Prefab>().AdjustJob();
                break;
        }

    }
    public void DisplayJobName()
    {
        switch (VillagersArray[0].GetComponent<Villager_Prefab>().currentJob)
        {
            case Villager_Prefab.WhatJobDoTheyHave.Hunting:
                Dropdown_1.GetComponent<TMP_Dropdown>().value = 0;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.Fishing:
                Dropdown_1.GetComponent<TMP_Dropdown>().value = 1;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.Cooking:
                Dropdown_1.GetComponent<TMP_Dropdown>().value = 2;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.None:
                Dropdown_1.GetComponent<TMP_Dropdown>().value = 3;
                break;
        }
        switch (VillagersArray[1].GetComponent<Villager_Prefab>().currentJob)
        {
            case Villager_Prefab.WhatJobDoTheyHave.Hunting:
                Dropdown_2.GetComponent<TMP_Dropdown>().value = 0;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.Fishing:
                Dropdown_2.GetComponent<TMP_Dropdown>().value = 1;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.Cooking:
                Dropdown_2.GetComponent<TMP_Dropdown>().value = 2;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.None:
                Dropdown_2.GetComponent<TMP_Dropdown>().value = 3;
                break;
        }
        switch (VillagersArray[2].GetComponent<Villager_Prefab>().currentJob)
        {
            case Villager_Prefab.WhatJobDoTheyHave.Hunting:
                Dropdown_3.GetComponent<TMP_Dropdown>().value = 0;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.Fishing:
                Dropdown_3.GetComponent<TMP_Dropdown>().value = 1;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.Cooking:
                Dropdown_3.GetComponent<TMP_Dropdown>().value = 2;
                break;
            case Villager_Prefab.WhatJobDoTheyHave.None:
                Dropdown_3.GetComponent<TMP_Dropdown>().value = 3;
                break;
        }
    }
}
