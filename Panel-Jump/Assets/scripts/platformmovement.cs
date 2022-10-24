using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmovement : MonoBehaviour
{
    public GameObject[] waypoints;

    int CurrentWayPointIndex = 0;

    float speed = 1f;


    void Start()
    {

    }

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[CurrentWayPointIndex].transform.position) < .1f)
        {
            CurrentWayPointIndex++;
            if (CurrentWayPointIndex >= waypoints.Length)
            {
                CurrentWayPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[CurrentWayPointIndex].transform.position, speed * Time.deltaTime);


    }
}
