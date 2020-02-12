using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TeamMars.Capstone.Manager
{


    public class SummaryPage : MonoBehaviour
    {
        public GameObject UI_ToClear;
        public GameObject UI_Summary;
        // Start is called before the first frame update
        void Start()
        {
            CloseSummary_UI();
        }

        // Update is called once per frame
        void Update()
        {
            if (GameManager.Instance.hours > 5)
            {
                Clear_UI();
                ShowSummary_UI();
            }
            

        }
        void Clear_UI()
        {
            UI_ToClear.SetActive(false);
        }
        void ShowSummary_UI()
        {
            UI_Summary.SetActive(true);
        }
        void Restore_UI()
        {
            UI_ToClear.SetActive(true);
        }
        void CloseSummary_UI()
        {
            UI_Summary.SetActive(false);
        }
    }
}
