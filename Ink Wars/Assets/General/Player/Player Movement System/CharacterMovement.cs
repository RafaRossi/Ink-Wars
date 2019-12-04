using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : CharacterComponent
{
    private CharacterController controller;

    private float moveSpeed = 0;
    public float MoveSpeed
    {
        get => moveSpeed;
        set 
        { 
            moveSpeed = value;
        }
    }

    private Vector2 direction = Vector2.zero;

    private Action<Vector2> OnDirectionChanged = delegate { };

    protected override void Awake()
    {
        base.Awake();

        controller = GetComponent<CharacterController>();
    }

    protected override void InitializeComponent()
    {
        MoveSpeed = Profile.speed;
    }
    public void OnMoveRequest(InputAction.CallbackContext context)
    {
       SetDirection(context.ReadValue<Vector2>());
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;

        OnDirectionChanged(this.direction);
    }

    private void FixedUpdate()
    {
        Move(new Vector3(direction.x, 0, direction.y));
    }

    public void Move(Vector3 direction)
    {
        controller.Move(direction * Time.fixedDeltaTime * MoveSpeed);  
    }
}
