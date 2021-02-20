using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowThePath : MonoBehaviour
{

    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 2f;

    public bool blackhole;


    private int waypointIndex = 0;

    private void Start()
    {

        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        if(blackhole)
            gameObject.transform.Rotate(0, 0, -50 * Time.deltaTime, Space.Self);
        Move();
    }

    private void Move()
    {

        if (waypointIndex <= waypoints.Length - 1)
        {

            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);


            if (Vector2.Distance(transform.position, waypoints[waypointIndex].transform.position) < 0.2f)
            {
                waypointIndex += 1;
            }
        }
        if (waypointIndex > waypoints.Length - 1)
            waypointIndex = 0;  

    }
}