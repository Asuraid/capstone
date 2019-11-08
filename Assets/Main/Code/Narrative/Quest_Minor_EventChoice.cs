using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PixelCrushers.DialogueSystem;

public class Quest_Minor_EventChoice : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.StartConversation("Quest_Minor_Prefab", gameObject.transform, gameObject.transform, 0);



            DialogueLua.SetVariable("Quest_Minor_EventTitle", "WHAT HAPPENNED?");

        DialogueLua.SetVariable("Quest_Minor_EventChoice_1", "EARTHQUAKE");
        DialogueLua.SetVariable("Quest_Minor_EventChoice_2", "BUILDING COLLAPSE");
        DialogueLua.SetVariable("Quest_Minor_EventChoice_3", "ELDRITCH HORROR");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
