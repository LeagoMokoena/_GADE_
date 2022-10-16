using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{

    public static WaypointManager instance;

    [SerializeField] private Transform waypoint1Transform;
    [SerializeField] private Transform waypoint2Transform;
    [SerializeField] private Transform waypoint3Transform;
    [SerializeField] private Transform waypoint4Transform;
    [SerializeField] private Transform waypoint5Transform;
    public LinkedList<Transform> waypoints = new LinkedList<Transform>();
    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public object this[int index]
    {
        get { return this; }
    }

    private void Start()
    {
        waypoints.AddLast(waypoint1Transform);
        waypoints.AddLast(waypoint2Transform);
        waypoints.AddLast(waypoint3Transform);
        waypoints.AddLast(waypoint4Transform);
        waypoints.AddLast(waypoint5Transform);

    }

    private Node head;
    private int count;


    public object GetNextWaypoint(int currentWaypointID)
    {
       Node node = this.head;
        for(int i = 0; i < currentWaypointID; i++)
            node = node.Next;

        return node;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
