using UnityEngine;
using TeamMars.Capstone.Manager.Resources;

namespace TeamMars.Capstone.Manager.Resources
{
    public class UseResources : MonoBehaviour
    {
        public enum UsedResources // your custom enumeration
        {
            None,
            RawGame,
            RawFish,
            Wood,
        };
        [Header("Used Resources")]
        [Tooltip("What resource will be used from this area; can be multiple.")]
        public bool usingRawFish;
        public bool usingCookedFish;

        public bool usingRawMeat;
        public bool usingCookedMeat;

        public int usedAmount;

        [Header("Resource Output")]
        [Tooltip("What resource will be gained from this area; can be multiple.")]
        public bool hasAnOutput;

        public bool gainRawFish;
        public bool gainCookedFish;

        public bool gainRawMeat;
        public bool gainCookedMeat;

        public int gainedAmount;

        bool advancedTime;

        private void OnMouseDown()
        {
            advancedTime = true;

            // If the item outputs things.
            if (hasAnOutput)
            {
                if (gainRawFish)
                {
                    ResourceManager.Instance.AddRawFish(gainedAmount);
                }

                // If cooked fish is gained, check if there are more than the used amount before proceeding.
                if (gainCookedFish && GameManager.Instance.rawFish >= usedAmount)
                {
                    ResourceManager.Instance.AddCookedFish(gainedAmount);
                }

                if (gainRawMeat)
                {
                    ResourceManager.Instance.AddRawGame(gainedAmount);
                }

                if (gainCookedMeat && GameManager.Instance.rawGame >= usedAmount)
                {
                    ResourceManager.Instance.AddCookedGame(gainedAmount);
                }
            }

            if (usingRawFish && GameManager.Instance.rawFish >= usedAmount)
            {
                ResourceManager.Instance.UseRawFish(usedAmount);
                AdvanceTime();
            }

            if (usingCookedFish)
            {
                ResourceManager.Instance.UseCookedFish(usedAmount);
                AdvanceTime();
            }

            if (usingRawMeat && GameManager.Instance.rawGame >= usedAmount)
            {
                ResourceManager.Instance.UseRawGame(usedAmount);
                AdvanceTime();
            }

            if (usingCookedMeat)
            {
                ResourceManager.Instance.UseCookedGame(usedAmount);
                AdvanceTime();
            }

            // Check if time was advanced, if it was already, don't do it again.
        }

        void AdvanceTime()
        {
            // Advance time.
            if (advancedTime)
            {
                GameManager.Instance.AddHours();
                advancedTime = !advancedTime;
            }
        }
    }
}
