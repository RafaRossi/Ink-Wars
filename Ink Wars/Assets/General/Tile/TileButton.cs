using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum SigantureColor
{
    Red, Blue, Yellow, Green
}

public class TileButton : Tile
{
    public static Action<SigantureColor> OnButtonPressed;

    public SigantureColor color;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnButtonPressed(color);
        }
    }
}
