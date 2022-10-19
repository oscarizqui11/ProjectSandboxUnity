using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnPointerDownListener : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent onPointerDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        onPointerDown.Invoke();
    }
}
