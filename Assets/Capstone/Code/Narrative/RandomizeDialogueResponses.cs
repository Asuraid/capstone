using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class RandomizeDialogueResponses : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnConversationResponseMenu(Response[] responses)
    {
        for (int t = 0; t < responses.Length; t++)
        {
            var temp = responses[t];
            int r = Random.Range(t, responses.Length);
            responses[t] = responses[r];
            responses[r] = temp;
        }
    }
}

