using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class CharacterFire : CharacterComponent
{
    public Action Fire = delegate { };
    
    protected override void InitializeComponent()
    {
        
    }

    public void OnFireRequest(InputAction.CallbackContext context)
    {
        FireRequest();
    }

    public void FireRequest()
    {
        Fire();
    }
}
