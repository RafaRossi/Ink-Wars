using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class VirtualJoystickControllerComponent : CharacterComponent
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
    public Vector2Event OnLeftJoystickAxisChanged = null;
    public Vector2Event OnRightJoystickAxisChange = null;
    public UnityEvent OnFireButtonPressed = null;
    public UnityEvent OnFireButtonRelease = null;
    
    protected override void InitializeComponent()
    {
        Joystick.LeftAnalog.OnAxisChanged += OnLeftJoystickAxisChanged.Invoke;
        Joystick.RightAnalog.OnAxisChanged += OnRightJoystickAxisChange.Invoke;

        Joystick.FireButton.OnButtonPressed += OnFireButtonPressed.Invoke;
        Joystick.FireButton.OnButtonReleased += OnFireButtonRelease.Invoke;
    }
}
