using UnityEngine;
using TMPro;

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

        int hours;
        int currentDay = 1;
        int seasons = 1;

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
            hours += 2;

            // Check if the days are more than the max amount of hours.
            if (hours >= maxHours)
            {
                currentDay++;
                hours = 0;
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
    }
}

