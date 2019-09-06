using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallButtonActivable : Wall
{
    public SigantureColor color;

    private void OnEnable()
    {
        TileButton.OnButtonPressed += Activate;
    }

    private void OnDisable()
    {
        TileButton.OnButtonPressed -= Activate;
    }

    private void Activate(SigantureColor color)
    {
        Debug.Log(color);
    }
}
