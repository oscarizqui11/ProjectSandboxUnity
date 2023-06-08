using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleExplosiveBarrel : MonoBehaviour
{
    [SerializeField] GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        explosion.transform.position= transform.position;
        explosion.GetComponent<ObstacleExplosion>().enabled = true;
        gameObject.SetActive(false);
    }
}
