using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleExplosiveBarrel : MonoBehaviour
{
    [SerializeField] GameObject explosion;

    private PlaySFXOnDie soundEfect;

    private void Start()
    {
        soundEfect= GetComponent<PlaySFXOnDie>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        explosion.transform.position= transform.position;
        explosion.GetComponent<ObstacleExplosion>().enabled = true;
        soundEfect.PlaySoundFX();
        gameObject.SetActive(false);
    }
}
