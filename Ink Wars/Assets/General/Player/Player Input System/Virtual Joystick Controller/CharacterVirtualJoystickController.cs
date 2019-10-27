using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterVirtualJoystickController : CharacterComponent
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
    private CharacterMovement movement;

    protected override void Awake()
    {
        base.Awake();

        movement = GetComponent<CharacterMovement>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        Joystick.OnAxisChanged += movement.SetDirection;
    }

    protected override void OnDisable()
    {
        base.OnEnable();

        Joystick.OnAxisChanged -= movement.SetDirection;
    }

    protected override void InitializeComponent()
    {
        
    }
}
