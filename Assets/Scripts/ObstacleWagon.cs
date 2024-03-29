using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleWagon : ObstacleBehaviour
{
    public Transform finishPoint;
    private Vector3 direction;

    private MovementBehaviour _mb;

    private void Start()
    {
        _mb = GetComponent<MovementBehaviour>();
        direction = finishPoint.position - transform.position;
        direction = direction.normalized;

        enabled = false;
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, finishPoint.position) > 0.5f)
            _mb.MoveTowards(direction);
    }
}
