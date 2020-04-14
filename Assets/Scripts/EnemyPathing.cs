using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] WaveConfig waveConfig;
    [SerializeField] List<Transform> wayPoints;
    [SerializeField] float moveSpeed = 2f;
    int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        wayPoints = waveConfig.GetWayPoints();
        transform.position = wayPoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypointIndex <= wayPoints.Count - 1)
        {
            var targetPosition = wayPoints[waypointIndex].transform.position;
            var movementThisFrame = moveSpeed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementThisFrame);
            //Debug.Log(targetPosition);
            if (transform.position == targetPosition)
            {
                waypointIndex++;
               // Debug.Log(waypointIndex);
            }
        }
        else
        {
            waypointIndex = 0;
        }
    }
}
