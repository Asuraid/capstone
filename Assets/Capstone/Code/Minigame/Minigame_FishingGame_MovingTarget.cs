using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TeamMars.Capstone.Manager.Resources
{
    public class Minigame_FishingGame_MovingTarget : MonoBehaviour
    {
        Vector3 startPosition;
        Vector3 endPosition;
        int direction;
        public float speed;
        // Start is called before the first frame update
        void Start()
        {
            startPosition = new Vector3(-8, 0, 0);
            endPosition = new Vector3(8, 0, 0);
            direction = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if (direction > 0)
            {
                if (transform.position.x < endPosition.x)
                {
                    transform.Translate(speed, 0, 0);
                }
                else
                {
                    direction = -1;
                }
            }
            else
            {
                if (transform.position.x > startPosition.x)
                {
                    transform.Translate(-speed, 0, 0);
                }
                else
                {
                    direction = 1;
                }

            }
        }
    }
}
