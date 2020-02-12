using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_TreeCutting_Dots : MonoBehaviour
{
    public bool isTrigger;

    public Minigame_TreeCutting_Manager Manager; 

    public GameObject[] ClickableDots_Left = new GameObject[3];
    public GameObject[] ClickableDots_Right = new GameObject[3];
    public GameObject[] ActivatedDots = new GameObject[6];



    public GameObject ShownDot_01;
    public GameObject ShownDot_02;

    float timeDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        isTrigger = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.isGame)
        {

            if (isTrigger)
            {
                ClearScreen();
                timeDelay -= Time.deltaTime;
                if (timeDelay <= 0)
                {
          
                    timeDelay = 2;
                    TriggerAppearence();
                    
                }
            }

        }
    }
    public void TriggerAppearence()
    {
        isTrigger = false;
        ShownDot_01 = ClickableDots_Left[(int)Random.Range(0,2.99f)];
       ShownDot_02 =  ClickableDots_Right[(int)Random.Range(0, 2.99f)];

        ShownDot_01.SetActive(true);
        ShownDot_02.SetActive(true);

    }
    public void ClearScreen ()
    {
  
        for (int i = 0; i < 6; i++)
        {
            ActivatedDots[i].SetActive(false);
        }

        for (int i = 0; i < 3; i++)
        {
            ClickableDots_Left[i].SetActive(false);
            ClickableDots_Right[i].SetActive(false);
        }
    }
    public void ClearActivation()
    {
        for (int i = 0; i < 6; i++)
        {
            ActivatedDots[i].SetActive(false);
        }
        ShownDot_01.SetActive(true);
        ShownDot_02.SetActive(true);
    }
}
