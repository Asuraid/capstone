using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TeamMars.Capstone.Manager.Resources
{
    public class Minigame_Hunting_Manager : MonoBehaviour
    {

        public GameObject[] Bow_Image;
        public GameObject[] Slider_Image;
        public int Bow_Position_x;
        public int Bow_Position_y;
        public bool isAiming;
        public GameObject Target_ParentGameObject;
        public GameObject[] Target_Image;
        public Vector2 TargetPosition_XY;
        public float resettargettimer;
        public bool ishit;
        public float timeuntilReset;
        public GameObject sliderbackground;
        public float TOTALGAME_Timer;
        public bool isGame;

        private void Start()
        {
            isGame = true;
            SetTargetInvisible();
            CreateRandomTargetPosition();
            SetTargetPosition();
        }
        // Update is called once per frame
        void Update()
        {
            if (isGame)
            {
                TOTALGAME_Timer -= Time.deltaTime;
                if (TOTALGAME_Timer < 0)
                {
                    isGame = false;
                }
                BowStateBasedOnMouse();
                SwitchBowStates();
                ClickAiming();
                TimerCountdown();
            }
        }
        void BowStateBasedOnMouse()
        {
            /// Bow X
            if ((Input.mousePosition.x / Screen.width) < 0.33f)
            {
                Bow_Position_x = 1;
            }
            else if ((Input.mousePosition.x / Screen.width) > 0.33f && (Input.mousePosition.x / Screen.width) < 0.66f)
            {
                Bow_Position_x = 2;
            }
            else if  (Input.mousePosition.x / Screen.width > 0.66f)                 
            {
                Bow_Position_x = 3;
            }
            else
            {
                Bow_Position_x = 1;
            }
            if (isAiming) {
                ///Bow Y
                if ((Input.mousePosition.y / Screen.height) < 0.33f)
                {
                    Bow_Position_y = 3;
                }
                else if ((Input.mousePosition.y / Screen.height) > 0.33f && (Input.mousePosition.y / Screen.height) < 0.66f)
                {
                    Bow_Position_y = 2;
                }
                else if (Input.mousePosition.y / Screen.height > 0.66f)
                {
                    Bow_Position_y = 1;
                }
                else
                {
                    Bow_Position_y = 3;
                }
            }
        }
        void SwitchBowStates()
        {
            if (!isAiming)
            {
                sliderbackground.SetActive(false);       
                switch (Bow_Position_x)
                {
                    case 1:
                        Bow_Image[0].SetActive(true);
                        Bow_Image[1].SetActive(false);
                        Bow_Image[2].SetActive(false);
                        break;
                    case 2:
                        Bow_Image[0].SetActive(false);
                        Bow_Image[1].SetActive(true);
                        Bow_Image[2].SetActive(false);
                        break;
                    case 3:
                        Bow_Image[0].SetActive(false);
                        Bow_Image[1].SetActive(false);
                        Bow_Image[2].SetActive(true);
                        break;
                }
            }
            if (isAiming)
            {
                sliderbackground.SetActive(true);
                switch (Bow_Position_y)
                {
                    case 1:
                        Slider_Image[0].SetActive(true);
                        Slider_Image[1].SetActive(false);
                        Slider_Image[2].SetActive(false);
                        break;
                    case 2:
                        Slider_Image[0].SetActive(false);
                        Slider_Image[1].SetActive(true);
                        Slider_Image[2].SetActive(false);
                        break;
                    case 3:
                        Slider_Image[0].SetActive(false);
                        Slider_Image[1].SetActive(false);
                        Slider_Image[2].SetActive(true);
                        break;
                }
            }
            else
            {
                Slider_Image[0].SetActive(false);
                Slider_Image[1].SetActive(false);
                Slider_Image[2].SetActive(false);
            }
        }
        void ClickAiming()
        {
            if (Input.GetMouseButtonDown(0))
            {
                isAiming = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                isAiming = false;
                CheckIfTargetHit();
            }
            if (Input.GetMouseButtonDown(1))
            {
                isAiming = false;
            }
        }
        void TimerCountdown()
        {
            resettargettimer -= Time.deltaTime;
            if (resettargettimer < 0)
            {
                SetTargetInvisible();
                CreateRandomTargetPosition();
                SetTargetPosition();
                resettargettimer = timeuntilReset;
            }
        }
        void CreateRandomTargetPosition()
        {
            TargetPosition_XY = new Vector2((int)Random.Range(1, 3.99f), (int)Random.Range(1, 3.99f));
        }
        void SetTargetPosition()
        {
                switch (TargetPosition_XY.x)
                {
                    case 1:
                        Target_ParentGameObject.transform.position = new Vector3(-4, Target_ParentGameObject.transform.position.y, 0);
                        break;
                    case 2:
                        Target_ParentGameObject.transform.position = new Vector3(0, Target_ParentGameObject.transform.position.y, 0);
                        break;
                    case 3:
                        Target_ParentGameObject.transform.position = new Vector3(4, Target_ParentGameObject.transform.position.y, 0);
                        break;
                }
                switch (TargetPosition_XY.y)
                {
                    case 1:
                        Target_ParentGameObject.transform.position = new Vector3(Target_ParentGameObject.transform.position.x, 0, 0);
                        break;
                    case 2:
                        Target_ParentGameObject.transform.position = new Vector3(Target_ParentGameObject.transform.position.x, 2, 0);
                        break;
                    case 3:
                        Target_ParentGameObject.transform.position = new Vector3(Target_ParentGameObject.transform.position.x, 4, 0);
                        break;
                }
            
        }
        void CheckIfTargetHit()
        {
            if (TargetPosition_XY == new Vector2(Bow_Position_x,Bow_Position_y))
            {
                Target_Image[0].SetActive(false);
                Target_Image[1].SetActive(true);
                print("HIT");
                resettargettimer = 2;
            }
        }
        void SetTargetInvisible()
        {
            Target_Image[0].SetActive(true);
            Target_Image[1].SetActive(false);
        }
        }
}