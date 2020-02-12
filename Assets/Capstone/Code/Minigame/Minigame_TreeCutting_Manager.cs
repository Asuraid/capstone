using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Minigame_TreeCutting_Manager : MonoBehaviour
{


    public bool isGame = true;
    public int Score;
    public TextMeshPro scoretext;
    public TextMeshPro Finalscoretext;
    public GameObject GamewinMenu;
    public Minigame_TreeCutting_Dots dots;

    public bool isMouseClickedDown;

    Vector3 mouseStartPos;

    //this is for math
    public int cuttingAddition;

    // Start is called before the first frame update
    void Start()
    {
        GamewinMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {


        if (isMouseClickedDown)
        {
            DrawLineRenderer();
        }


        if (Input.GetMouseButtonDown(0))
        {
            mouseStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMouseClickedDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            dots.ClearActivation();
            cuttingAddition = 0;
            isMouseClickedDown = false;
        }

        if (isGame)
        {
            scoretext.text = Score.ToString();

            if (cuttingAddition >=2)
            {
                cuttingAddition = 0;
                Score++;
                dots.ClearScreen();
                dots.TriggerAppearence();
                dots.isTrigger = true;
            }
        }
        else
        {
            GamewinMenu.SetActive(true);
            Finalscoretext.text = Score.ToString();
        }
    }

    void DrawLineRenderer()
    {
        print(mouseStartPos);
        Debug.DrawLine(new Vector3(mouseStartPos.x, mouseStartPos.y, 0),new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0) , Color.red);
        Debug.DrawLine(mouseStartPos, Camera.main.ScreenToWorldPoint(Input.mousePosition), Color.red);
    }
}
