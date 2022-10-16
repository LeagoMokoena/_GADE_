using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mesh_Agents : MonoBehaviour
{


    int index = 0;

    public NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = (Vector3)WaypointManager.instance.GetNextWaypoint(index);
        index++;
    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }


    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        agent.destination = (Vector3)WaypointManager.instance.GetNextWaypoint(index);
        index++;
               
    }
}
