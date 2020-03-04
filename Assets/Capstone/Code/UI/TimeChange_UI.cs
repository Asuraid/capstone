using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TeamMars.Capstone.Manager
{
    public class TimeChange_UI : MonoBehaviour
    {
        public Sprite[] TimeImages = new Sprite[5];

        public SpriteRenderer TimeUI;
        // Start is called before the first frame update
        void Start()
        {
            TimeImages = new Sprite[5];
        }

        // Update is called once per frame
        void Update()
        {
            TimeUI.sprite = TimeImages[GameManager.Instance.hours];
        }
    }
}