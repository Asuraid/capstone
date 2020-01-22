using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class VillagerAnimation : MonoBehaviour
{
    Animator animator;
    CharacterController controller;
    bool isMoving;
    int speed;

    public Transform forestTarget;
    public Transform fishTarget;
    public Transform home;

    AIDestinationSetter aiDestination;

    private void Awake()
    {
        if (animator == null)
            animator = GetComponent<Animator>();
        else
            print("There is no animator attached!");

        if (controller == null)
            controller = GetComponent<CharacterController>();
        else
            print("There is no controller attached!");

        if (aiDestination == null)
            aiDestination = GetComponent<AIDestinationSetter>();
        else
            print("There is no controller attached!");
    }

    // Update is called once per frame
    void Update()
    {

        if (controller.velocity != Vector3.zero)
        {

            bool isMoving = true;

            animator.SetBool("moving", isMoving);

        }

        if (controller.velocity == Vector3.zero)
        {
            bool isMoving = false;

            animator.SetBool("moving", isMoving);

        }

        if (Input.GetKeyDown("space"))
        {
            aiDestination.target = fishTarget;
        }
    }


}
