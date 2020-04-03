using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace TeamMars.Capstone.Manager.Resources
{

    public class Minigame_Fishing_GameManager : MonoBehaviour
    {
        public float meterMax;
        public float meterCurrent;
        public GameObject MovingTarget;
        public GameObject Catcher;
        public float ScoreIncreaseScale;
        public float DetectionRange;
        public float Score;
        public GameObject VialMeter;
        public float Timer;
        public GameObject WindowToClose;
        public GameObject WinScreen;

        public GameObject Building_or_Structure;
        public TextMeshPro ScoreText;
        public TextMeshPro TimerText;
        public TextMeshPro FinalScoreText;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {






            if (Timer > 0)
            {









                SetCameraLocation();

                if (Mathf.Abs(MovingTarget.transform.position.x - Catcher.transform.position.x) < DetectionRange)
                {
                    meterCurrent += ScoreIncreaseScale;
                }

                if (meterCurrent > meterMax)
                {
                    meterCurrent = 0;
                    Score++;
                }

                Timer = Timer - Time.deltaTime;


                UpdateText();
                UpdateVial();
            }
            else 
            {
                GameManager.Instance.ResumeScrolling();
                StopGame();
         

            }
        }
        void UpdateText()
        {
            ScoreText.text = Score.ToString();
            TimerText.text = ((int)Timer).ToString();
        }
        void UpdateVial()
        {
            VialMeter.transform.localScale = new Vector3((meterCurrent / meterMax) * 1.5f, VialMeter.transform.localScale.y, VialMeter.transform.localScale.z);
        }
        public void PlayGame()
        {
            Timer = 10;
        }
        public void StopGame()
        {
            Timer = 0;
            WindowToClose.SetActive(false);
            WinScreen.SetActive(true);
            FinalScoreText.text = ScoreText.text;

            /////////////////////////////////////////////////////

            Building_or_Structure.GetComponent<GatherResource>().AddResource((Score + 10)/10);
            print((Score + 10)/10);

            ////////////////////////////////////////////////////
   
            Reset();


        }
        public void SetCameraLocation()
        {
            Camera.main.transform.position = new Vector3(0, 0, Camera.main.transform.position.z);
            GameManager.Instance.StopScrolling();
        }
        public void Reset()
        {
            Score = 0;
            meterCurrent = 0;
       

        }
    }
}