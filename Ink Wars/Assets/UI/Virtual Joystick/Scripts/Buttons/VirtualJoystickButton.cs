using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public abstract class VirtualJoystickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Action OnButtonPressed = delegate { };
    public Action OnButtonReleased = delegate { };

    public void OnPointerDown(PointerEventData eventData)
    {
        OnButtonPressed();
        Debug.Log("ok");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnButtonReleased();
    }
}
