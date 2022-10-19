using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnPointerUpListener : MonoBehaviour, IPointerUpHandler
{
    public UnityEvent onPointerUp;

    public void OnPointerUp(PointerEventData eventData)
    {
        onPointerUp.Invoke();
    }
}
