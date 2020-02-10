using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamMars.Capstone.Manager.Resources
{
    public class StartMinigame : MonoBehaviour
    {
        public Minigame_Fishing_GameManager MinigameToPlay;
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
            MinigameToPlay.PlayGame();
            WindowtoClose.SetActive(false);
            WindowtoOpen.SetActive(true);
        }
    }
}
