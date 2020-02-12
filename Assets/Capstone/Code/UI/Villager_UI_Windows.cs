using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_UI_Windows : MonoBehaviour
{
    public GameObject VillagerWindow_WorldSpace;
    public GameObject VillagerWindow_ScreenSpace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (VillagerWindow_WorldSpace.activeSelf == true)
        {
            VillagerWindow_ScreenSpace.SetActive(true);

        }
        else
        {
            VillagerWindow_ScreenSpace.SetActive(false);

        }
        
    }
}
