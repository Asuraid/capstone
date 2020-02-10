using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TeamMars.Capstone.Manager.Resources
{
    public class Toolbar_Alert : MonoBehaviour
    {
        public GameObject Toolbar_AlertSprite;
        public GameObject Toolbar_CookedFish_AlertSprite;
        public GameObject Toolbar_RawFish_AlertSprite;
        public GameObject Toolbar_CookedGame_AlertSprite;
        public GameObject Toolbar_RawGame_AlertSprite;
        public GameObject Toolbar_FoodAlert;

        public int TotalFoodSupply;
        public int TotalNumberofVillagers;

        // Start is called before the first frame update
        void Start()
        {
            Toolbar_AlertSprite.SetActive(false);
            Toolbar_RawFish_AlertSprite.SetActive(false);
            Toolbar_CookedFish_AlertSprite.SetActive(false);
            Toolbar_CookedGame_AlertSprite.SetActive(false);
            Toolbar_RawGame_AlertSprite.SetActive(false);
            Toolbar_FoodAlert.SetActive(false);

            TotalNumberofVillagers = GameObject.FindGameObjectsWithTag("Villager").Length;
        }

        // Update is called once per frame
        void Update()
        {
            TotalFoodSupply = (GameManager.Instance.cookedFish + GameManager.Instance.cookedGame);

            
            if (TotalFoodSupply < TotalNumberofVillagers)
            {
                Toolbar_AlertSprite.SetActive(true);
                Toolbar_FoodAlert.SetActive(true);
            }
            else
            {
                Toolbar_AlertSprite.SetActive(false);
                Toolbar_FoodAlert.SetActive(false);
            }






        }
    }
}
