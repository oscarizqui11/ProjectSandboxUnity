using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehaviour : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<HealthBehaviour>(out HealthBehaviour otherHealth))
        {
            otherHealth.Hurt(damage);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<HealthBehaviour>(out HealthBehaviour otherHealth))
        {
            otherHealth.Hurt(damage);
        }
    }
}
