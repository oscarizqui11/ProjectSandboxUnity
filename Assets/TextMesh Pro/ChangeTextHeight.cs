using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextHeight : MonoBehaviour
{
    private RectTransform _rt;

    // Start is called before the first frame update
    void Start()
    {
        _rt = GetComponent<RectTransform>();
    }

    public void SetTextHeight(float newHeight)
    {
        _rt.anchoredPosition = new Vector2(0, newHeight);
    }
}
