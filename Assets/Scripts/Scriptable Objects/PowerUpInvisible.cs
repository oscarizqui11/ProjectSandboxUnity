using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Invisible")]
public class PowerUpInvisible : PowerUp
{
    public float time;

    public override void Apply()
    {
        Debug.Log("Invisible");
    }
}
