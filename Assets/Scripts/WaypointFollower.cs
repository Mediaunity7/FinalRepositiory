using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
     [SerializeField] GameObject[] waypoints;
     int currentWaypointIndex = 0;

     [SerializeField] float speed = 1f;


    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f) // if the way point touch we switch to other if not no 
        {
            currentWaypointIndex++; 
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);   //making frame rate independant so that we alwys move one game unit not matter the frame per second is 
    }
}
