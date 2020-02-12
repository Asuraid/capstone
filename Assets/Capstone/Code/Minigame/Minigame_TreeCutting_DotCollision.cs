using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_TreeCutting_DotCollision : MonoBehaviour
{
    public Minigame_TreeCutting_Manager manager;

    public GameObject GameObject_Clicked;
    // Start is called before the first frame update
    void Start()
    {
        manager = transform.parent.parent.GetComponent<Minigame_TreeCutting_Manager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (manager.isMouseClickedDown)
        {
            gameObject.SetActive(false);
            GameObject_Clicked.SetActive(true);
            manager.cuttingAddition++;
        }
    }
}
