using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

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
        public int wood;

        [Header("Time")]
        public int maxHours;
        public int maxDay;
        public int hourIncrements = 2;

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
                    cookedFish--;
                else
                    cookedGame--;
                eatingCount++;
            }

            eatingCount = 0;
            yield return null;
        }
    }
}

