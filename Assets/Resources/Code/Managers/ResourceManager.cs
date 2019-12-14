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

        // Start is called before the first frame update
        void Start()
        {
            rawFish.text = GameManager.Instance.rawFish.ToString();
            cookedFish.text = GameManager.Instance.cookedFish.ToString();
            rawGame.text = GameManager.Instance.rawGame.ToString();
            cookedGame.text = GameManager.Instance.cookedGame.ToString();
        }

        public void AddRawGame(int amount)
        {
            GameManager.Instance.rawGame += amount;
            GameManager.Instance.AddHours();
            UpdateResources();
        }

        public void AddRawFish(int amount)
        {
            GameManager.Instance.rawFish += amount;
            GameManager.Instance.AddHours();
            UpdateResources();
        }

        void UpdateResources()
        {
            rawFish.text = GameManager.Instance.rawFish.ToString();
            cookedFish.text = GameManager.Instance.cookedFish.ToString();
            rawGame.text = GameManager.Instance.rawGame.ToString();
            cookedGame.text = GameManager.Instance.cookedGame.ToString();
        }
    }
}

