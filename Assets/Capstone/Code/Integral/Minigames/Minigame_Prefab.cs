using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_Prefab : MonoBehaviour
{

    float minRange = -10;
    float maxRange = 10;
    public float playerValue = 0;
    public float fishValue = 0;
    public float catchRange = 0.1f;
    public bool isCaught = false;
    public float timeinLoop = 0;
    public int FishCaught = 0;
    public float fishDelay = 3;
    public bool isFishVisible = false;

    public GameObject FishSprite;
    public GameObject cursorSprite;

    float fishSpeed = 1;

    float GameTime = 30;




    // Start is called before the first frame update
    void Start()
    {
        ResetFish();

    }

    // Update is called once per frame
    void Update()
    {

   

        if (FishCaught < 3)
        {
            GameTime += Time.deltaTime;

            if (isFishVisible == false)
            {

                fishSpeed = 0;
            }
            else
            {
                fishSpeed = 0.5f;
            }



            FishSprite.SetActive(isFishVisible);



            FishSprite.transform.position = new Vector3(fishValue, 0, 0);
            cursorSprite.transform.position = new Vector3(playerValue, 0, 0);



            if (isFishVisible == false)
            {
                fishDelay -= Time.deltaTime;
                if (fishDelay < 0)
                {
                    fishDelay = 3;
                    isFishVisible = true;
                }
            }


            fishValue = Mathf.PingPong(Time.time * fishSpeed, 20) - 10;


            if (Input.GetKey("e"))
            {
                playerValue += 0.1f;
            }
            if (Input.GetKey("q"))
            {
                playerValue -= 0.1f;
            }

            if (playerValue > maxRange)
            {
                playerValue = maxRange;
            }
            if (playerValue < minRange)
            {
                playerValue = minRange;
            }


            print(Mathf.Abs(playerValue - fishValue));



            if (Mathf.Abs(playerValue - fishValue) < catchRange && isFishVisible)
            {
                isCaught = true;
                timeinLoop += Time.deltaTime;
            }
            else
            {
                isCaught = false;
                timeinLoop = 0;
            }


            if (timeinLoop > 6)
            {
                Caughtfish();
            }
        }
        else
        {
            print("YOU CAUGHT 3 FISH IN: " + GameTime +" SECONDS");
        }

    }




   void  Caughtfish()
    {
        print("I CAUGHT THE FISH");
        isFishVisible = false;
        timeinLoop = 0;
        FishCaught += 1;
        isCaught = false;
        ResetFish();
    }


    void ResetFish()
    {
        fishValue = Random.Range(-10f, 10f);
        fishValue = Mathf.Round(fishValue * 100f) / 100f;
    }
}
