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

    [Space][Header("Left Joystick Analog")]
    public Vector2Event OnLeftJoystickAxisChanged = null;
    public UnityEvent OnLeftJoystickPressed = null;
    public UnityEvent OnLeftJoystickReleased = null;

    [Space][Header("Right Joystick Analog")]
    public Vector2Event OnRightJoystickAxisChanged = null;
    public UnityEvent OnRightJoystickPressed = null;
    public UnityEvent OnRightJoystickReleased = null;

    [Space][Header ("Buttons")]
    public UnityEvent OnFireButtonPressed = null;
    public UnityEvent OnFireButtonRelease = null;
    
    protected override void InitializeComponent()
    {
        Joystick.LeftAnalog.OnAxisChanged += OnLeftJoystickAxisChanged.Invoke;
        Joystick.LeftAnalog.OnAxisReleased += OnLeftJoystickReleased.Invoke;
        Joystick.LeftAnalog.OnAxisPressed += OnLeftJoystickPressed.Invoke;

        Joystick.RightAnalog.OnAxisChanged += OnRightJoystickAxisChanged.Invoke;
        Joystick.RightAnalog.OnAxisReleased += OnRightJoystickReleased.Invoke;
        Joystick.RightAnalog.OnAxisPressed += OnRightJoystickPressed.Invoke;

        Joystick.FireButton.OnButtonPressed += OnFireButtonPressed.Invoke;
        Joystick.FireButton.OnButtonReleased += OnFireButtonRelease.Invoke;
    }
}
