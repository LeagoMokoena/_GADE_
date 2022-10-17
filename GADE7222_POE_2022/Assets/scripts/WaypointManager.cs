using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    Node head;
    public static WaypointManager Instance;
    public bool found = false;


    [SerializeField] private Transform waypoint1Transform;
    [SerializeField] private Transform waypoint2Transform;
    [SerializeField] private Transform waypoint3Transform;
    [SerializeField] private Transform waypoint4Transform;
    [SerializeField] private Transform waypoint5Transform;
    public LinkedList<Transform> waypoints = new LinkedList<Transform>();
    private void Awake()
    {
        if(Instance == null)
            Instance = this;
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


    public Transform GetNextWaypoint(int currentWaypointID)
    {
       Node node = head;
        int count = 0;
        while(found != false)
        {
            if(count == currentWaypointID)
            {
                found = true;
            }
            else
            {
                count++;
                node = node.next;
            }
        }

        return node.data;
        
    
    }

    public void push(Transform newdata)
    {
        Node newnode = new Node(newdata);

        newnode.next = head;

        head = newnode;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
