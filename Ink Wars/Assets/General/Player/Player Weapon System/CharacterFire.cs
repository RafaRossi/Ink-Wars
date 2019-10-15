using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class CharacterFire : MonoBehaviour
{
    public void OnFireRequest(InputAction.CallbackContext context)
    {
        Fire();
    }

    public event Action Fire;
}
