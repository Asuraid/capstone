using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamMars.Capstone.Manager.Resources
{
    public class StartMinigame : MonoBehaviour
    {
        public Minigame_Fishing_GameManager MinigameToPlay_fish;
        public Minigame_TreeCutting_Manager MinigameToPlay_tree;
        public Minigame_Hunting_Manager MinigameToPlay_hunting;
        public GameObject WindowtoClose;
        public GameObject WindowtoOpen;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnMouseDown()
        {

            if (MinigameToPlay_tree != null)
            {
                MinigameToPlay_tree.timer = 10;
                WindowtoClose.SetActive(false);
                WindowtoOpen.SetActive(true);
            }
            if (MinigameToPlay_fish != null)
            {
                MinigameToPlay_fish.PlayGame();
                WindowtoClose.SetActive(false);
                WindowtoOpen.SetActive(true);
            }
            if (MinigameToPlay_hunting != null)
            {
                MinigameToPlay_hunting.PlayGame();
                WindowtoClose.SetActive(false);
                WindowtoOpen.SetActive(true);
            }
        }
    }
}
