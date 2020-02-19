using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



namespace TeamMars.Capstone.Manager.Resources
{
    public class Minigame_TreeCutting_Manager : MonoBehaviour
    {


        public GameObject windowtoopen;
        public GameObject windowtoclose;
        public GameObject Building_Or_Structure;

        public int timer = 10;

        public int Score;
        public TextMeshPro scoretext;
        public TextMeshPro Finalscoretext;
        public GameObject GamewinMenu;
        public Minigame_TreeCutting_Dots dots;

        public bool isMouseClickedDown;

        Vector3 mouseStartPos;

        //this is for math
        public int cuttingAddition;


        public LineRenderer LineRendererObject;

        public Vector3 screenPoint;
        public Vector3 worldPoint;

        // Start is called before the first frame update
        void Start()
        {
            GamewinMenu.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {




            if (timer > 8)
            {




                //turns off certain objects when mouse is unclicked
                if (!isMouseClickedDown)
                {
                    dots.ClearActivation();
                }




                worldPoint.z = 0;


                if (isMouseClickedDown)
                {
                    DrawLineRenderer();
                }


                if (Input.GetMouseButtonDown(0))
                {
                    LineRendererObject.SetPosition(0, new Vector3(0, mouseStartPos.y, -mouseStartPos.x));
                    LineRendererObject.SetPosition(1, new Vector3(0, mouseStartPos.y, -mouseStartPos.x));
                    LineRendererObject.gameObject.SetActive(true);
                    screenPoint = Input.mousePosition;
                    worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
                    mouseStartPos = worldPoint;


                    isMouseClickedDown = true;
                }
                if (Input.GetMouseButtonUp(0))
                {
                    //dots.ClearActivation();
                    cuttingAddition = 0;
                    isMouseClickedDown = false;
                }

                scoretext.text = Score.ToString();

                if (cuttingAddition >= 2)
                {
                    cuttingAddition = 0;
                    Score++;
                    timer--;
                    dots.ClearScreen();
                    dots.TriggerAppearence();
                    dots.isTrigger = true;
                }
            }

            else
            {


                /////////////////////////////////////////////////////

                Building_Or_Structure.GetComponent<GatherResource>().AddResource((Score + 10) / 10);
                print((Score + 10) / 10);

                ////////////////////////////////////////////////////


                GamewinMenu.SetActive(true);
                Finalscoretext.text = Score.ToString();
                windowtoclose.SetActive(false);
            }
        }

        void DrawLineRenderer()
        {
            print(mouseStartPos);
            //Debug.DrawLine(new Vector3(mouseStartPos.x, mouseStartPos.y, 0),new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0) , Color.red);



            screenPoint = Input.mousePosition;
            worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
            worldPoint.z = 0;



            LineRendererObject.SetPosition(0, new Vector3(-6, mouseStartPos.y, -mouseStartPos.x));
            LineRendererObject.SetPosition(1, new Vector3(-6, worldPoint.y, -worldPoint.x));
            LineRendererObject.transform.position = new Vector3(0, 0, 0);
            //  Debug.DrawLine(mouseStartPos, Camera.main.ScreenToWorldPoint(Input.mousePosition), Color.red);
        }
    }
}