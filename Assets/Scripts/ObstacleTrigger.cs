using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    private ObstacleBehaviour _obstacle;

    private void Start()
    {
        _obstacle = transform.parent.GetComponentInChildren<ObstacleBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _obstacle.enabled = true;

        if(_obstacle.TryGetComponent<Animator>(out Animator _anim))
        {
            _anim.SetBool("isTriggered", true);
        }
    }
}
