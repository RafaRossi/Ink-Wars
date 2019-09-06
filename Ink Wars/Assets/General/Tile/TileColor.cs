using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileColor : Tile
{
    private event Action OnEnterTile;
    private event Action OnExitTile;
}
