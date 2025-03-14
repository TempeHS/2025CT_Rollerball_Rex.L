using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementTwo : MonoBehaviour
{

    public Transform player;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        transform. position = new Vector3(-8f, 0.5f, 8f);
    }

    void Update()
    {
        if (player != null)
        {    
            navMeshAgent.SetDestination(player.position);
        }
    }
}
