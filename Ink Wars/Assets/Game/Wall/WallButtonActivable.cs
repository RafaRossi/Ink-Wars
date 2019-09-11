using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallButtonActivable : Wall, IActivable
{
    public SignatureColor color;

    private void OnEnable()
    {
        TileButton.OnButtonPressed += GetComponent<IActivable>().Activate;
    }

    private void OnDisable()
    {
        TileButton.OnButtonPressed -= GetComponent<IActivable>().Activate;
    }

    void IActivable.Activate()
    {
        Debug.Log("Activated");
    } 
}
