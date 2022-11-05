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
    }

    private void FixedUpdate()
    {
        if(isActive)
        {
            _mb.MoveTowards(direction);
        }
    }
}
