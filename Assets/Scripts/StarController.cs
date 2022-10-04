using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<HealthBehaviour>().Hurt(1);
    }
}
