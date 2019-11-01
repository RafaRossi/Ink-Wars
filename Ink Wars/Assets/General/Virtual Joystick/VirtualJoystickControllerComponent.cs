using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class VirtualJoystickControllerComponent : MonoBehaviour
{
    [SerializeField] private VirtualJoystick joystick;
    public VirtualJoystick Joystick
    {
        get
        {
            if(!joystick)
            {
                joystick = FindObjectOfType<VirtualJoystick>();
            }
            return joystick;
        }
    }

    [SerializeField]
    public Vector2Event OnJoystickAxisChanged = null;
    public UnityEvent OnFireButtonPressed = null;
    public UnityEvent OnFireButtonRelease = null;

    private void OnEnable()
    {
        Joystick.Analog.OnAxisChanged += OnJoystickAxisChanged.Invoke;

        Joystick.FireButton.OnButtonPressed += OnFireButtonPressed.Invoke;
        Joystick.FireButton.OnButtonReleased += OnFireButtonRelease.Invoke;
    }
    private void OnDisable()
    {
        Joystick.Analog.OnAxisChanged -= OnJoystickAxisChanged.Invoke;

        Joystick.FireButton.OnButtonPressed -= OnFireButtonPressed.Invoke;
        Joystick.FireButton.OnButtonReleased -= OnFireButtonRelease.Invoke;
    }
}
