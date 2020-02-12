using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound_OnClick : MonoBehaviour
{
    public string SoundEvent_Name;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        AkSoundEngine.PostEvent(SoundEvent_Name, gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
