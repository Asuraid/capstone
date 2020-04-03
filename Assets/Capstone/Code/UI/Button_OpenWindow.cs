using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TeamMars.Capstone.Manager.Resources
{
    public class Button_OpenWindow : MonoBehaviour
    {

        public GameObject Window;
        public GameObject Window2;
        public GameObject WindowtoClose;

        public bool isOven;
        public bool isAccess;
         GameObject noAccessCross;



        // Start is called before the first frame update
        void Start()
        {
            isAccess = true;
            if (transform.parent.parent.name == "Oven_ICON")
            {
                isOven = true;
                if (transform.GetChild(0).gameObject.name == "MinigameButton_NoAccess")
                {
                    noAccessCross = transform.GetChild(0).gameObject;
                }
                else
                {
                    noAccessCross = null;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            
            
            if (isOven)
            {
                if ((GameManager.Instance.rawFish + GameManager.Instance.rawGame) > 0)
                {
                    isAccess = true;
                    if (noAccessCross != null)
                    {
                        noAccessCross.SetActive(false);
                    }
                }
                else
                {
                    isAccess = false;
                    if (noAccessCross != null)
                    {
                        noAccessCross.SetActive(true);
                    }
                }
            }
        }
        private void OnMouseDown()
        {
            if (isAccess == true)
            {
                if (Window != null)
                {
                    Window.SetActive(true);
                }
                
                if (Window2 != null)
                {
                    Window2.SetActive(true);
                }
                WindowtoClose.SetActive(false);
            }

            GameManager.Instance.UnPauseGame();
            }
    }
}
