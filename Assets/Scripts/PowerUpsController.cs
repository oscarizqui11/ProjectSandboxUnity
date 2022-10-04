using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsController : MonoBehaviour
{
    public PowerUp activePowerUp;
    
    private float durationPowerUp;
    private PowerUp storedPowerUp;

    private void Start()
    {
        activePowerUp = null;
        durationPowerUp = 0;
    }

    public void FixedUpdate()
    {
        if (durationPowerUp > 0)
        {
            if (activePowerUp != null)
            {
                Debug.Log(durationPowerUp);
                durationPowerUp -= Time.fixedDeltaTime;
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                if (storedPowerUp)
                {
                    storedPowerUp.Apply();
                    activePowerUp = storedPowerUp;
                    storedPowerUp = null;
                }

            }
        }
        else
        {
            durationPowerUp = 0.0f;
        }
    }

    public void SetPowerUp(PowerUp powerUp)
    {
        storedPowerUp = powerUp;
        durationPowerUp = powerUp.duration;
    }
}

