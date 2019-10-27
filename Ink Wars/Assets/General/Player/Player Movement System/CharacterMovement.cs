using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : CharacterComponent
{
    private CharacterController controller;

    [SerializeField]
    private float MoveSpeed
    {
        get
        {
            return Profile.speed;
        }

        set
        {
            Profile.speed = value;
        }
    }

    [SerializeField]
    private float turnSpeed = 0.1f;

    private float turnSmoothVelocity = 0;

    private Vector2 direction = Vector2.zero;

    protected override void Awake()
    {
        base.Awake();

        controller = GetComponent<CharacterController>();
    }

    protected override void InitializeComponent()
    {
        
    }
    public void OnMoveRequest(InputAction.CallbackContext context)
    {
       SetDirection(context.ReadValue<Vector2>());
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    private void FixedUpdate()
    {
        Move(new Vector3(direction.x, 0, direction.y));
    }

    public void Move(Vector3 direction)
    {
        controller.Move(direction * Time.fixedDeltaTime * MoveSpeed* Time.fixedDeltaTime * MoveSpeed);

        if (direction == Vector3.zero)
            return;

        float desiredRotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, desiredRotation, ref turnSmoothVelocity, turnSpeed);
    }
}
