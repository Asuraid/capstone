using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcess_DayNightCycle : MonoBehaviour
{
    public int Hour = 0;
    public int HourMax = 10;
    public PostProcessProfile profileMain;
    public ColorGrading colourGrading;


    public Vector4 colourGrading_ColourFilter_Value;

    public Vector4[] colourGrading_ColourFilters = new Vector4[6];


    public Vector4 colourGrading_ColourFilter_night;

    // Start is called before the first frame update
    void Start()
    {
        Hour = 0;
        HourMax = 10;




        colourGrading = profileMain.GetSetting<ColorGrading>();


        colourGrading_ColourFilters[0] = new Vector4(1, 0.65f, 0.55f, -50f); // orange
        colourGrading_ColourFilters[1] = new Vector4(1, 0.825f, 0.775f, 0f);
        colourGrading_ColourFilters[2] = new Vector4(1, 1f, 1f, 50f); // neutral
        colourGrading_ColourFilters[3] = new Vector4(0.775f, 0.825f, 1f, 0f);
        colourGrading_ColourFilters[4] = new Vector4(0.55f, 0.65f, 1f, -50f); //blue
        colourGrading_ColourFilters[5] = new Vector4(0, 0, 0f,-100); //night



        colourGrading_ColourFilter_Value = colourGrading_ColourFilters[0];
        colourGrading.brightness.value = colourGrading_ColourFilters[Hour].w;





    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown("i"))
        {
     

            Hour++;
            if (Hour <= 5)
            {
                colourGrading_ColourFilter_Value = colourGrading_ColourFilters[Hour];
   
                colourGrading.brightness.value = colourGrading_ColourFilters[Hour].w;
            }
            if (Hour > 5)
            {
                Hour = 0;

                colourGrading_ColourFilter_Value = colourGrading_ColourFilters[Hour];

                colourGrading.brightness.value = colourGrading_ColourFilters[Hour].w;
            }
            
        }
  



    

        colourGrading.colorFilter.value = colourGrading_ColourFilter_Value;



    }
}
