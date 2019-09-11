using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTerritorial : MonoBehaviour
{
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
        }
    }

    [SerializeField]
    private int points;
    public int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
        }
    }

    private void OnEnable()
    {
        TileColor.OnChangeColor += UpdatePoints;
    }

    private void UpdatePoints()
    {
        Points = TerritorialLevelManager.Instance.characterPoints[Color];
    }

    private void OnDisable()
    {
        TileColor.OnChangeColor -= UpdatePoints;
    }
}
