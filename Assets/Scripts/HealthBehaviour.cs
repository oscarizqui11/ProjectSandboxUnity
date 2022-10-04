using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{

    public int maxHealth;
    private int health;

    public UnityEvent onDie;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            onDie.Invoke();
        }
    }
}
