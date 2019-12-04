using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class CharacterFire : CharacterComponent
{
    public event Action Fire;

    private Vector2 direction = Vector2.zero;

    protected override void InitializeComponent()
    {
        
    }

    private void Update() 
    {
        if(direction != Vector2.zero)
        {
            FireRequest();
        }
    }

    public void OnFireRequest(InputAction.CallbackContext context)
    {
        SetAimDirection(transform.forward);
    }

    public void FireRequest()
    {
        Fire();
    }

    public void SetAimDirection(Vector2 direction)
    {
        this.direction = direction;
    }
}
