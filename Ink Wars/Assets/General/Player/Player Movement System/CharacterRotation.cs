using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterRotation : CharacterComponent
{   
    private float turnSpeed = 0.1f;
    private float turnSmoothVelocity = 0;

    private Vector2 direction = Vector2.zero;

    private Action<Vector2> OnRotationChanged = delegate { };

    protected override void InitializeComponent()
    {
        
    }

    public void OnRotateRequest(InputAction.CallbackContext context)
    {
       SetRotation(context.ReadValue<Vector2>());
    }

    public void SetRotation(Vector2 direction)
    {
        this.direction = direction;

        OnRotationChanged(this.direction);
    }

    private void FixedUpdate() 
    {
        Rotate(new Vector3(direction.x, 0, direction.y));
    }
    
    public void Rotate(Vector3 direction)
    {
        if (direction == Vector3.zero)
            return;

        float desiredRotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, desiredRotation, ref turnSmoothVelocity, turnSpeed);
    }
}
