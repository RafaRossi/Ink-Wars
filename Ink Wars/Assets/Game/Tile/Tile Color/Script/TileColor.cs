using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileColor : Tile
{
    private event Action OnEnterTile;
    private event Action OnExitTile;
    private event Action OnChangeColor;

    private SigantureColor color;

    public SigantureColor Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;

            OnChangeColor.Invoke();
        }
    }
}
