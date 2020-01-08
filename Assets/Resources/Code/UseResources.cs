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

        private void OnMouseDown()
        {
            // If the item outputs things.
            if (hasAnOutput)
            {
                if (gainRawFish)
                {
                    ResourceManager.Instance.AddRawFish(gainedAmount);
                }

                if (gainCookedFish && GameManager.Instance.rawFish > 0)
                {
                    ResourceManager.Instance.AddCookedFish(gainedAmount);
                }
                else
                {
                    print(GameManager.Instance.rawFish);
                    print("Not enough materials.");
                }

                if (gainRawMeat)
                {
                    ResourceManager.Instance.AddRawGame(gainedAmount);
                }

                if (gainCookedMeat && GameManager.Instance.rawGame > 0)
                {
                    ResourceManager.Instance.AddCookedGame(gainedAmount);
                }
                else
                {
                    print("Not enough materials.");
                }
            }

            if (usingRawFish && GameManager.Instance.rawFish > 0)
            {
                ResourceManager.Instance.UseRawFish(usedAmount);
            }

            if (usingCookedFish)
            {
                ResourceManager.Instance.UseCookedFish(usedAmount);
            }

            if (usingRawMeat)
            {
                ResourceManager.Instance.UseRawGame(usedAmount);
            }

            if (usingCookedMeat)
            {
                ResourceManager.Instance.UseCookedGame(usedAmount);
            }
        }
    }
}
