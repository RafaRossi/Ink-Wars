using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(CharacterBase))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private CharacterBase character;

    private Rigidbody rb;

    [SerializeField]
    private float moveSpeed = 15;

    [SerializeField]
    private float turnSpeed = 0.1f;

    private float turnSmoothVelocity = 0;

    private Vector3 direction;

    public void Awake()
    {
        character = GetComponent<CharacterBase>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        direction = character.Input.Direction;
    }

    private void FixedUpdate()
    {
        Move(direction);
    }

    public void Move(Vector3 direction)
    {
        controller.Move(direction * Time.fixedDeltaTime * moveSpeed* Time.fixedDeltaTime * moveSpeed);

        if (direction == Vector3.zero)
            return;

        float desiredRotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, desiredRotation, ref turnSmoothVelocity, turnSpeed);
    }
}
