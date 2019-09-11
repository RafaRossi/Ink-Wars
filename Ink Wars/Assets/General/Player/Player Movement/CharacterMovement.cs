using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;

    [SerializeField]
    private float moveSpeed = 10;

    [SerializeField]
    private float turnSpeed = 0.1f;

    private float turnSmoothVelocity = 0;

    public void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction)
    {      
        controller.Move(direction * Time.fixedDeltaTime * moveSpeed);

        if (direction == Vector3.zero)
            return;

        float desiredRotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, desiredRotation, ref turnSmoothVelocity, turnSpeed);
    }
}
