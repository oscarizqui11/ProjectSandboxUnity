using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleExplosion : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    SphereCollider sphereCollider;

    [SerializeField] float explosionLifeTime;
    float timer;

    private void Awake()
    {
        sphereCollider = GetComponent<SphereCollider>();
    }

    private void OnEnable()
    {
        ActiveExplosion(true);

        timer = 0;
    }

    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        if(timer > explosionLifeTime )
        {
            ActiveExplosion(false);

            enabled = false;
        }
    }

    void ActiveExplosion(bool active)
    {
        sphereCollider.enabled = active;
        explosion.SetActive(active);
    }
}
