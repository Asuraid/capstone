﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Movement : MonoBehaviour
{
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
