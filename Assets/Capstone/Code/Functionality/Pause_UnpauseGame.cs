using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TeamMars.Capstone.Manager.Resources
{



        public class Pause_UnpauseGame : MonoBehaviour
        {

            public static Pause_UnpauseGame Instance { get; private set; }

            // Start is called before the first frame update
            void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
   
        }

        public void PauseGame()
        {
            Time.timeScale = 0;
            print("Game has been paused!");
        }
        public void UnPauseGame()
        {
            Time.timeScale = 1;
            print("Game has been Unpaused!");
        }
    }
}