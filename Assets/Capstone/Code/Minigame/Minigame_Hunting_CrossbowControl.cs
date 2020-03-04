using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_Hunting_CrossbowControl : MonoBehaviour
{

    //crossbow has 3 directions. Left Middle and Right
    //based on mouse x position


    public int CrossbowDirection_X = 0; // 1 left 2 middle 3 right
    public int CrossbowDirection_Y = 0; // 1 far 2 middle 3 close
    public float mouseX; // mouse x position fraction based on screen width
    public float mouseY_OnClick; // mouse y position when mouse is clicked and held down
    public float mouseY; // mouse y position fraction based on screen height and where player clicked
    public bool ismouseClick; // detects if mouse is held down
    public float Scale_Bar_Initial;//the bar's intial location
    public float Scale_Bar_Location; //the bar's current location
    public float Scale_Bar_Max; //the bar's maximum location
    public int crossbowdirection_chosen; // crossbow direction when clicked
    public float mouseY_Porportion; //to save time typing

    public bool isFire;
    public float timer = 2;


    public GameObject Crossbow_Left_Visual;
    public GameObject Crossbow_Middle_Visual;
    public GameObject Crossbow_Right_Visual;


    public GameObject Aim_Scale_Visual;
    public GameObject Aim_Bar_Visual;

    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
        Aim_Bar_Visual.SetActive(false);
        Aim_Scale_Visual.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //this happens when the player has NOT fired yet
        if (!isFire)
        {

            //////////////////////////////////////////////// mouse X
            mouseX = Input.mousePosition.x / Screen.width;
            if (mouseX > 1)
            {
                mouseX = 1;
            }
            else if (mouseX < 0)
            {
                mouseX = 0;
            }



            //////////////////////////////////////////////// mouse direction
            if (mouseX > 0 && mouseX < 0.33f)
            {
                CrossbowDirection_X = 1;
            }
            if (mouseX > 0.33f && mouseX < 0.66f)
            {
                CrossbowDirection_X = 2;
            }
            if (mouseX > 0.66f && mouseX < 1)
            {
                CrossbowDirection_X = 3;
            }

            ////////////////////////////////////////////////// mouse Y

            if (ismouseClick)
            {

                //keeps mouse x consistent
                CrossbowDirection_X = crossbowdirection_chosen;





                mouseY = Input.mousePosition.y - mouseY_OnClick;

                if (mouseY > 0)
                {
                    mouseY = 0;
                }


                mouseY_Porportion = Mathf.Abs(mouseY / mouseY_OnClick);


                if (mouseY_Porportion > 0f && mouseY_Porportion < 0.33f)
                {
                    CrossbowDirection_Y = 1;
                }

                if (mouseY_Porportion > 0.33f && mouseY_Porportion < 0.66f)
                {
                    CrossbowDirection_Y = 2;
                }
                if (mouseY_Porportion > 0.66f && mouseY_Porportion < 1)
                {
                    CrossbowDirection_Y = 3;
                }
                else if (mouseY_Porportion > 1)
                {
                    mouseY_Porportion = 1;
                    CrossbowDirection_Y = 3;
                }
                else if (mouseY_Porportion < 0)
                {
                    CrossbowDirection_Y = 1;
                    mouseY_Porportion = 0;
                }

                //Mathf.Abs(mouseY / mouseY_OnClick) is a variable from  0 to 1 based on the minimum pull to the maximum pull
                //0 is the initial location
                //1 is the maximum location



                Aim_Bar_Visual.SetActive(true);
                Aim_Scale_Visual.SetActive(true);




                Scale_Bar_Max = Scale_Bar_Initial - 2;
                Scale_Bar_Location = ((Scale_Bar_Max- Scale_Bar_Initial) * mouseY_Porportion) + 1;
                print(Scale_Bar_Location);

                Aim_Bar_Visual.transform.position = new Vector3(Aim_Scale_Visual.transform.position.x, (Scale_Bar_Location + Scale_Bar_Initial) / 2, Aim_Scale_Visual.transform.position.z);


            }
            else
            {
                Aim_Bar_Visual.SetActive(false);
                Aim_Scale_Visual.SetActive(false);
            }





            /////////////////////////////////////////////////// mouse click
            if (Input.GetMouseButtonDown(0))
            {
                crossbowdirection_chosen = CrossbowDirection_X;
                Scale_Bar_Initial = Aim_Bar_Visual.gameObject.transform.position.y;


                ismouseClick = true;
                mouseY_OnClick = Input.mousePosition.y;

            }
            if (Input.GetMouseButtonUp(0))
            {
                ismouseClick = false;
                isFire = true;
            }
            if (Input.GetMouseButtonDown(1))
            {
                Aim_Bar_Visual.SetActive(false);
                Aim_Scale_Visual.SetActive(false);
                ismouseClick = false;
                mouseY_OnClick = 0;
                mouseY = 0;
            }





            //////////////////////////////////////////////////  visuals
            switch (CrossbowDirection_X)
            {
                case 1:
                    Crossbow_Left_Visual.SetActive(true);
                    Crossbow_Middle_Visual.SetActive(false);
                    Crossbow_Right_Visual.SetActive(false);
                    break;
                case 2:
                    Crossbow_Left_Visual.SetActive(false);
                    Crossbow_Middle_Visual.SetActive(true);
                    Crossbow_Right_Visual.SetActive(false);
                    break;
                case 3:
                    Crossbow_Left_Visual.SetActive(false);
                    Crossbow_Middle_Visual.SetActive(false);
                    Crossbow_Right_Visual.SetActive(true);
                    break;
            }

        }
        else
        {
            timer-= Time.deltaTime;
            if (timer <0) {
                isFire = false;
                timer = 2;
            }
        }
    }


}
