using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerInput 
{
    public float Horizontal
    {
        get
        {
            return Input.GetAxis("Horizontal");
        }
    }

    public float Vertical
    {
        get
        {
            return Input.GetAxis("Vertical");
        }
    }

    public bool IsShooting
    {
        get
        {
            return Input.GetButton("Fire1");
        }
    }
}

[RequireComponent(typeof(CharacterMovement))]
public class CharacterBase : MonoBehaviour
{
    private PlayerInput input;
    private CharacterMovement characterMovement;

    private void Awake()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        Vector3 direction = new Vector3(input.Horizontal, 0, input.Vertical);

        characterMovement.Move(direction);
        characterMovement.Rotate(direction);
    }
}
