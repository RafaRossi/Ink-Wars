using System;
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

    public Vector3 Direction
    {
        get
        {
            return new Vector3(Horizontal, 0, Vertical);
        }
    }

    public bool IsShooting
    {
        get
        {            
            return Input.GetButton("Fire1"); ;
        }
    }
}

public enum PlayerID
{
    Player1, Player2, Player3, Player4, Default
}

public class CharacterBase : MonoBehaviour
{
    public PlayerInput Input { get; set; }
    public PlayerID PlayerID { get; set; }
}
