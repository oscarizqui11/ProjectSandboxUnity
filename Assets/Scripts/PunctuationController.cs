using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunctuationController : MonoBehaviour
{
    private Image _img;

    public int achivingPunctuation;
    public Sprite achievedSprite;

    // Start is called before the first frame update
    void Start()
    {
        _img = GetComponent<Image>();
    }

    public void SetAcchievedPunctuation(int points)
    {
        if(points >= achivingPunctuation)
            _img.sprite = achievedSprite;
    }
}
