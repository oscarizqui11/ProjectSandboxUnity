using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpGiver : MonoBehaviour
{
    public UnityEvent<PowerUp> OnGivePowerUp;
    public PowerUp powerUp;

    public void GivePowerUp()
    {
        OnGivePowerUp.Invoke(powerUp);
    }
}
