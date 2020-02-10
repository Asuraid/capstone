using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamMars.Capstone.Manager;
using TeamMars.Capstone.Manager.Resources;

namespace TeamMars.Capstone
{
    public class CraftBuilding : MonoBehaviour
    {
        [Header("Used Resources")]
        [Tooltip("What resource will be required to craft this building + the needed amount.")]
        public bool usingRawWood;
        public bool usingRefinedWood;

        public int neededAmount;

        [Header("Built Object")]
        public GameObject builtObject;

        private void OnMouseDown()
        {
            if(GameManager.Instance.rawWood >= neededAmount)
            {
                builtObject.SetActive(true);
                ResourceManager.Instance.UseRawWood(neededAmount);
                transform.gameObject.SetActive(false);
            } else
            {
                print("Not enough wood!");
            }
        }
    }
}
