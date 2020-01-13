using UnityEngine;
using TMPro;

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
            rawFish.text = GameManager.Instance.rawFish.ToString();
            cookedFish.text = GameManager.Instance.cookedFish.ToString();
            rawGame.text = GameManager.Instance.rawGame.ToString();
            cookedGame.text = GameManager.Instance.cookedGame.ToString();
        }

        #region Adding resources
        public void AddRawGame(int amount)
        {
            GameManager.Instance.rawGame += amount;
            UpdateResources();
        }

        public void AddRawFish(int amount)
        {
            GameManager.Instance.rawFish += amount;
            UpdateResources();
        }

        public void AddCookedGame(int amount)
        {
            GameManager.Instance.cookedGame += amount;
            UpdateResources();
        }

        public void AddCookedFish(int amount)
        {
            GameManager.Instance.cookedFish += amount;
            UpdateResources();
        }
        #endregion

        #region Using resources
        public void UseRawGame(int amount)
        {
            GameManager.Instance.rawGame -= amount;
            UpdateResources();
        }

        public void UseRawFish(int amount)
        {
            GameManager.Instance.rawFish -= amount;
            UpdateResources();
        }

        public void UseCookedGame(int amount)
        {
            GameManager.Instance.cookedGame -= amount;
            UpdateResources();
        }

        public void UseCookedFish(int amount)
        {
            GameManager.Instance.cookedFish -= amount;
            UpdateResources();
        }
        #endregion

        void UpdateResources()
        {
            rawFish.text = GameManager.Instance.rawFish.ToString();
            cookedFish.text = GameManager.Instance.cookedFish.ToString();
            rawGame.text = GameManager.Instance.rawGame.ToString();
            cookedGame.text = GameManager.Instance.cookedGame.ToString();
        }
    }
}

