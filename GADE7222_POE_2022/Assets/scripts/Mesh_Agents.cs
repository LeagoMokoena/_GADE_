using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mesh_Agents : MonoBehaviour
{


    int index = 0;
    [SerializeField] private Transform waypoint1Transform;
    [SerializeField] private Transform waypoint2Transform;
    [SerializeField] private Transform waypoint3Transform;
    [SerializeField] private Transform waypoint4Transform;
    [SerializeField] private Transform waypoint5Transform;
    public NavMeshAgent agent;

    private void Start()
    {
        WaypointManager.Instance.push(waypoint5Transform);
        WaypointManager.Instance.push(waypoint4Transform);
        WaypointManager.Instance.push(waypoint3Transform);
        WaypointManager.Instance.push(waypoint2Transform);
        WaypointManager.Instance.push(waypoint1Transform);

        agent.destination = WaypointManager.Instance.GetNextWaypoint(index).position;
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
               
    }
}
