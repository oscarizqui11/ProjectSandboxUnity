using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreBehaviour : MonoBehaviour
{
    public enum Role
    {
        COLLECTABLE,
        PLAYER,
        UI
    }

    public Role role;

    public int scorePoints;
    public int scoreMultiplier;

    public IntEvent onScored;

    private void OnEnable()
    {
        PowerUpMultiplier.onMultiply += SetMultiplier;
    }
    private void OnDisable()
    {
        PowerUpMultiplier.onMultiply -= SetMultiplier;
    }

    public void AddScore(int points)
    {
        scorePoints += points * scoreMultiplier;

        onScored.Invoke(scorePoints);
    }

    public void SetMultiplier(int newMultiplier)
    {
        scoreMultiplier = newMultiplier; 
    }

}
