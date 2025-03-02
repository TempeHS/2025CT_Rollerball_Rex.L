using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform player;
    private NavMeshAgent navMeshAgent;
    public float speed;
    public bool IsColliding = false;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        transform. position = new Vector3(-10f, 0.5f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
       {    
           navMeshAgent.SetDestination(player.position);
       }
    }
}
