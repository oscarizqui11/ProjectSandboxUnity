using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    protected bool isActive;

    private void Start()
    {
        isActive = false;
    }

    public void StartBehaviour()
    {
        isActive = true;
    }
}
