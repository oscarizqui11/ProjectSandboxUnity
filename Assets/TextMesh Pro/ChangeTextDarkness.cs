using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTextDarkness : MonoBehaviour
{
    private TextMeshProUGUI _tmProUGUI;

    private Color32 originalColor;
    public Color32 pressedColor;

    // Start is called before the first frame update
    void Start()
    {
        _tmProUGUI = GetComponent<TextMeshProUGUI>();
        originalColor = _tmProUGUI.faceColor;
    }

    public void SetTextDarkness(bool pressed)
    {
        if(pressed)
            _tmProUGUI.faceColor = pressedColor;
        else
            _tmProUGUI.faceColor = originalColor;
    }
}
