using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileColor : Tile
{
    public static event Action OnChangeColor;

    [SerializeField]
    private SignatureColor color;
    public SignatureColor Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;

            ChangeColor();
        }
    }

    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material = TerritorialLevelManager.pairs[Color];

        OnChangeColor();
    }

    private void OnTriggerEnter(Collider other)
    {
        CharacterTerritorial character = other.GetComponent<CharacterTerritorial>();

        if (character)
        {
            if(character.Color != Color)
            {
                TerritorialLevelManager.Instance.UpdatePoints(Color, -1);
                TerritorialLevelManager.Instance.UpdatePoints(character.Color, 1);

                Color = character.Color;
            }          
        }
    }
}
