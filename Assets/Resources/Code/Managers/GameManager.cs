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
        int currentDay = 1;
        int seasons = 1;

        [Header("Villagers")]
        public int villagerNumber = 1;
        int eatingCount;

        [Header("Time TextMeshPro")]
        public TextMeshPro textHours;
        public TextMeshPro textDays;
        public TextMeshPro textSeasons;

        /// <summary>
        /// Set up instance of the game manager. Remove extra instances.
        /// </summary>
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

        /// <summary>
        /// Update needed text for the game when it starts.
        /// </summary>
        private void Start()
        {
            UpdateText();
        }

        /// <summary>
        /// Time management. Will work for days.
        /// </summary>
        public void AddHours()
        {
            // Add hours based off the increment.
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

            // Change season if required.
            if (currentDay >= maxDay)
            {
                seasons++;
                currentDay = 1;
                Mathf.Clamp(seasons, 0, 4);
            }

            // Update the needed texts.
            UpdateText();
        }

        /// <summary>
        /// Update all required text.
        /// </summary>
        void UpdateText()
        {
            textHours.text = "Hours: " + hours + " / " + maxHours;
            textDays.text = "Days: " + currentDay + " / " + maxDay;

            // Switch seasons if required, change text as well.
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

        /// <summary>
        /// Reduce food numbers depending on the amount of villagers. Eating count rises up for each villager so the function only runs as many times as needed.
        /// </summary>
        /// <returns>null</returns>
        private IEnumerator FeedVillagers()
        {
            // Eat cooked fish first before moving onto meat.
            while(eatingCount < villagerNumber)
            {
                if (cookedFish > 0)
                    cookedFish--;
                else
                    cookedGame--;
                eatingCount++;
            }

            // Reset eating count for next time the game requires food consumption.
            eatingCount = 0;
            yield return null;
        }
    }
}

