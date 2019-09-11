using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum SignatureColor
{
    Red, Blue, Yellow, Green, White
}

public class TileButton : Tile
{
    public static Action OnButtonPressed;

    public SignatureColor color;
}
