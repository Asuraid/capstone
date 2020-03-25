using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PlayerManager : MonoBehaviour
{
    // Tied to animation, don't touch.
    public float animationActiveDistance;
    public float movementSpeed = 1;

    Animator animator;
    AIDestinationSetter aiDestination;
    AIPath aiPath;
    CharacterController controller;
    bool isMoving;
    bool isWorking;
    public GameObject axeObject;
    Vector3 ogScale;

    private void Awake()
    {
        // Simple checks to see if certain things are not attached.
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
            print("There is no AI Destination attached!");

        if (aiPath == null)
            aiPath = GetComponent<AIPath>();
        else
            print("There is no AI Path attached!");

        if (axeObject == null)
            print("There is no axe attached!");

        // Save original scale.
        ogScale = transform.localScale;

        movementSpeed = aiPath.maxSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Set object to inactive.
        axeObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("clicking mouse");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            aiPath.destination = mousePos2D;
        }

        // Check if the villager is moving.
        if (controller.velocity != Vector3.zero)
        {
            bool isMoving = true;

            animator.SetBool("moving", isMoving);
        }

        // If the villager is not moving, switch to idle animation.
        if (controller.velocity == Vector3.zero)
        {
            bool isMoving = false;

            animator.SetBool("moving", isMoving);
        }

        //if (aiPath.remainingDistance <= animationActiveDistance)
        //{
        //    bool isWorking = true;
        //    axeObject.gameObject.SetActive(true);

        //    animator.SetBool("working", isWorking);
        //}
        //else
        //{
        //    bool isWorking = false;
        //    axeObject.gameObject.SetActive(false);

        //    animator.SetBool("working", isWorking);
        //}

        // These two functions control the direction the sprite is facing towards.
        if (controller.velocity.x > 0)
        {
            transform.localScale = new Vector3(-ogScale.x, ogScale.y, ogScale.z);
        }

        if (controller.velocity.x < 0)
        {
            transform.localScale = new Vector3(ogScale.x, ogScale.y, ogScale.z);
        }
    }
}
