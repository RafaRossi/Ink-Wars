using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum SigantureColor
{
    Red, Blue, Yellow, Green, White
}

public class TileButton : Tile
{
    public static Action OnButtonPressed;

    public SigantureColor color;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnButtonPressed();
        }
    }
}
