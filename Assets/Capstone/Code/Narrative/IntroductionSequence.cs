using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
public class IntroductionSequence : MonoBehaviour
{

    public DialogueDatabase diaData;
    // Start is called before the first frame update
    void Start()
    {
        diaData = GetComponent<DialogueSystemController>().initialDatabase;   
    }

    // Update is called once per frame
    void Update()
    {
        print(DialogueLua.GetVariable("WhatCharacter").AsInt);   
    }
}
