using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/Speed")]
public class PowerUpSpeed : PowerUp
{
    public int multiplier;

    public override void Apply()
    {
        Debug.Log("Speed");
    }
}
