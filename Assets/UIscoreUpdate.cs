using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIscoreUpdate : MonoBehaviour
{
    public void UpdateUIScore(int newScore)
    {
        gameObject.GetComponent<TMP_Text>().text = newScore.ToString();
    }
}
