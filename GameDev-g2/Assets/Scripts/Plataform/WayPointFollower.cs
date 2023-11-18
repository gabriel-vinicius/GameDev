using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWayPointIdex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWayPointIdex].transform.position, transform.position) < .1f)
        {
            currentWayPointIdex++;
            if (currentWayPointIdex >= waypoints.Length)
            {
                currentWayPointIdex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWayPointIdex].transform.position, Time.deltaTime * speed);

    }
}
