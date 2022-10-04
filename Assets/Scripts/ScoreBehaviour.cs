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

    public IntEvent onScored;

    public void AddScore(int points)
    {
        scorePoints += points;

        onScored.Invoke(scorePoints);
    }

}
