using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "PowerUps/Multiplier")]
public class PowerUpMultiplier : PowerUp
{
    public int multiplier;

    public static UnityAction<int> onMultiply;

    public override void Apply()
    {
        onMultiply?.Invoke(multiplier);
    }
}
