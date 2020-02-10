using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamMars.Capstone.Manager.Resources;

namespace TeamMars.Capstone.Manager.Resources
{
    public class GatherResource : MonoBehaviour
    {
        [Header("Resource Output")]
        [Tooltip("What resource will be gained from this area; can be multiple.")]
        public bool gainRawFish;

        public bool gainRawMeat;

        public bool gainWood;

        public int gainedAmount;


        //Rather than pressing the mouse button down, I will make this function get called whenever the player chooses a minigame or lets a villager handle it
        public  void AddResource(float howmuch)
        {
            // Advance time.
            GameManager.Instance.AddHours();

            if (gainRawFish)
            {
                ResourceManager.Instance.AddRawFish((int)(gainedAmount * howmuch));
            }

            if (gainRawMeat)
            {
                ResourceManager.Instance.AddRawGame((int)(gainedAmount * howmuch));
            }

            if (gainWood)
            {
                ResourceManager.Instance.AddRawWood((int)(gainedAmount * howmuch));
            }

        }
    }
}
