using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class CharacterFire : CharacterComponent
{
    public event Action Fire;
    
    protected override void InitializeComponent()
    {
        
    }

    public void OnFireRequest(InputAction.CallbackContext context)
    {
        Fire();
    }
}
