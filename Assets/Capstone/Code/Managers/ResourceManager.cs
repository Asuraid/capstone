using UnityEngine;
using TMPro;
using System.Collections;

namespace TeamMars.Capstone.Manager.Resources
{
    public class ResourceManager : MonoBehaviour
    {
        public static ResourceManager Instance { get; private set; }

        [Header("TextMeshPro References")]
        public TextMeshPro rawFish;
        public TextMeshPro cookedFish;
        public TextMeshPro rawGame;
        public TextMeshPro cookedGame;
        public TextMeshPro rawWood;
        public TextMeshPro refinedWood;

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
        /// At the beginning, update all text.
        /// </summary>
        void Start()
        {
            UpdateResources();
        }

        #region Adding resources
        public void AddRawGame(int amount)
        {
            GameManager.Instance.rawGame += amount;
            rawGame.GetComponent<Text_Bump>().Bump();
            rawGame.GetComponent<Text_Bump>().colorChangingPositive = true;
            UpdateResources();
        }

        public void AddRawFish(int amount)
        {
            GameManager.Instance.rawFish += amount;
            rawFish.GetComponent<Text_Bump>().Bump();
            rawFish.GetComponent<Text_Bump>().colorChangingPositive = true;
            UpdateResources();
        }

        public void AddCookedGame(int amount)
        {
            GameManager.Instance.cookedGame += amount;
            cookedGame.GetComponent<Text_Bump>().Bump();
            cookedGame.GetComponent<Text_Bump>().colorChangingPositive = true;
            UpdateResources();
        }

        public void AddCookedFish(int amount)
        {
            GameManager.Instance.cookedFish += amount;
            cookedFish.GetComponent<Text_Bump>().Bump();
            cookedFish.GetComponent<Text_Bump>().colorChangingPositive = true;
            UpdateResources();
        }

        public void AddRawWood(int amount)
        {
            GameManager.Instance.rawWood += amount;
            rawWood.GetComponent<Text_Bump>().Bump();
            rawWood.GetComponent<Text_Bump>().colorChangingPositive = true;
            UpdateResources();
        }

        public void AddRefinedWood(int amount)
        {
            GameManager.Instance.refinedWood += amount;
            refinedWood.GetComponent<Text_Bump>().Bump();
            refinedWood.GetComponent<Text_Bump>().colorChangingPositive = true;
            UpdateResources();
        }
        #endregion

        #region Using resources
        /// <summary>
        /// Use a set amount of raw game.
        /// </summary>
        /// <param name="amount">Amount of raw game.</param>
        public void UseRawGame(int amount)
        {
            GameManager.Instance.rawGame -= amount;
            rawGame.GetComponent<Text_Bump>().Bump();
            UpdateResources();
        }

        /// <summary>
        /// Use a set amount of raw fish.
        /// </summary>
        /// <param name="amount">Amount of raw fish.</param>
        public void UseRawFish(int amount)
        {
            GameManager.Instance.rawFish -= amount;
            rawFish.GetComponent<Text_Bump>().Bump();
            UpdateResources();
        }

        /// <summary>
        /// Use a set amount of cooked game.
        /// </summary>
        /// <param name="amount">Amount of cooked game.</param>
        public void UseCookedGame(int amount)
        {
            GameManager.Instance.cookedGame -= amount;
            cookedGame.GetComponent<Text_Bump>().Bump();
            UpdateResources();
        }

        /// <summary>
        /// Use a set amount of cooked fish.
        /// </summary>
        /// <param name="amount">Amount of cooked fish.</param>
        public void UseCookedFish(int amount)
        {
            GameManager.Instance.cookedFish -= amount;
            cookedFish.GetComponent<Text_Bump>().Bump();
            UpdateResources();
        }

        /// <summary>
        /// Use a set amount of raw wood.
        /// </summary>
        /// <param name="amount">Amount of raw wood.</param>
        public void UseRawWood(int amount)
        {
            GameManager.Instance.rawWood -= amount;
            rawWood.GetComponent<Text_Bump>().Bump();
            UpdateResources();
        }

        /// <summary>
        /// Use a set amount of refined wood.
        /// </summary>
        /// <param name="amount">Amount of refined wood.</param>
        public void UseRefinedWood(int amount)
        {
            GameManager.Instance.refinedWood -= amount;
            refinedWood.GetComponent<Text_Bump>().Bump();
            UpdateResources();
        }
        #endregion

        /// <summary>
        /// Update all resource texts using the variables located in the Game Manager.
        /// </summary>
        public void UpdateResources()
        {

            rawFish.text = GameManager.Instance.rawFish.ToString();
            cookedFish.text = GameManager.Instance.cookedFish.ToString();
            //rawGame.text = GameManager.Instance.rawGame.ToString();
            //cookedGame.text = GameManager.Instance.cookedGame.ToString();
            rawWood.text = GameManager.Instance.rawWood.ToString();
            refinedWood.text = GameManager.Instance.refinedWood.ToString();
        }


    }
}

