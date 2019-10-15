using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(CharacterBase))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private CharacterBase character;

    [SerializeField]
    private float MoveSpeed
    {
        get
        {
            return character.speed.Value;
        }

        set
        {
            character.speed.Value = value;
        }
    }

    [SerializeField]
    private float turnSpeed = 0.1f;

    private float turnSmoothVelocity = 0;

    private Vector2 direction = Vector2.zero;

    public void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public void OnMoveRequest(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
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
