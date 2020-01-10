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

        public int gainedAmount;

        private void OnMouseDown()
        {
            // Advance time.
            GameManager.Instance.AddHours();

            if (gainRawFish)
            {
                ResourceManager.Instance.AddRawFish(gainedAmount);
            }

            if (gainRawMeat)
            {
                ResourceManager.Instance.AddRawGame(gainedAmount);
            }

        }
    }
}
