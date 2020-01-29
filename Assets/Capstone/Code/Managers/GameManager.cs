using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TeamMars.Capstone.Manager.Resources;

namespace TeamMars.Capstone.Manager
{
    public class GameManager : MonoBehaviour
    {
   
        public static GameManager Instance { get; private set; }

        [Header("Resources")]
        // All persistent variables.
        public int rawGame;
        public int cookedGame;
        public int rawFish;
        public int cookedFish;
        public int rawWood;
        public int refinedWood;

        [Header("Time")]
        public int maxHours;
        public int maxDay;
        public int hourIncrements = 2;
        public int resetTimerForScene = 1;

        int hours;
        public int currentDay = 1;
        int seasons = 1;

        [Header("Resources")]
        public int villagerNumber = 1;
        int eatingCount;

        [Header("Time TextMeshPro")]
        public TextMeshPro textHours;
        public TextMeshPro textDays;
        public TextMeshPro textSeasons;
        public TextMeshPro foodWarning;

        int temporaryStarvationMeter;


        private void Awake()
        {
            if (Instance != null && Instance != this)
                Destroy(gameObject);
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
       
        private void Start()
        {
            UpdateText();
        }

        public void AddHours()
        {
            hours += hourIncrements;

            // Check if the days are more than the max amount of hours. Move onto next day if so. Use up food storage.
            if (hours > maxHours)
            {
                currentDay++;
                hours = 0;
                eatingCount = 0;

                print("New day.");

                // If there is enough food, execute this.
                if ((cookedFish + cookedGame) >= villagerNumber)
                {
                    StartCoroutine(FeedVillagers());
                } else
                {
                    print("The villager(s) starved.");
                    temporaryStarvationMeter++;
                    foodWarning.transform.gameObject.SetActive(true);

                    if (temporaryStarvationMeter >= 2)
                    {
                        foodWarning.text = "Your villagers are very hungry ... it is unlikely they will last one more day.";
                    }

                    if (temporaryStarvationMeter >= 3)
                    {
                        foodWarning.text = "Unfortunately your villagers starved.";
                        StartCoroutine(Countdown(resetTimerForScene));
                    }
                }
            }

            if (currentDay >= maxDay)
            {
                seasons++;
                currentDay = 1;
                Mathf.Clamp(seasons, 0, 4);
            }

            UpdateText();
        }

        void UpdateText()
        {
            textHours.text = "Hours: " + hours + " / " + maxHours;
            textDays.text = "Days: " + currentDay + " / " + maxDay;

            switch (seasons)
            {
                case 1:
                    textSeasons.text = "Season: Spring";
                    break;
                case 2:
                    textSeasons.text = "Season: Summer";
                    break;
                case 3:
                    textSeasons.text = "Season: Fall";
                    break;
                case 4:
                    textSeasons.text = "Season: Winter";
                    break;
                default:
                    print("Something happened to bring it to default.");
                    break;
            }
        }

        private IEnumerator FeedVillagers()
        {
            while(eatingCount < villagerNumber)
            {
                if (cookedFish > 0)
                {
                    cookedFish--;
                }  
                else
                {
                    cookedGame--;
                } 
                eatingCount++;
            }
            ResourceManager.Instance.cookedFish.GetComponent<Text_Bump>().Bump();
            eatingCount = 0;
            yield return null;
        }

        private IEnumerator Countdown(int countdown)
        {
            float duration = countdown; // 3 seconds you can change this 
                                 //to whatever you want
            float normalizedTime = 0;
            while (normalizedTime <= 1f)
            {
                normalizedTime += Time.deltaTime / duration;
                yield return null;
            }

            print("reset scene here");
            SceneManager.LoadScene("Scene_Zone01");
        }
    }
}

