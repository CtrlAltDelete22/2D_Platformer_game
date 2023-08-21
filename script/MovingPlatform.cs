using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int CurrentWaypointIntIndex = 0;
    [SerializeField] private float speed = 2f;
    
    // Update is called once per frame
    [SerializeField]
    private void Update()
    {
        if (Vector2.Distance(wayPoints[CurrentWaypointIntIndex].transform.position, transform.position) < 0.1f)
            {
            CurrentWaypointIntIndex++;
            if(CurrentWaypointIntIndex >= wayPoints.Length) 
            {
                CurrentWaypointIntIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[CurrentWaypointIntIndex].transform.position, Time.deltaTime * speed);
    }
}
