using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleExplosion : MonoBehaviour
{
    [SerializeField] GameObject explosion;

    private void OnEnable()
    {
        GetComponent<SphereCollider>().enabled = true;
        explosion.SetActive(true);
    }
}
