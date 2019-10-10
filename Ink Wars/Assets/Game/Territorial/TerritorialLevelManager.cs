using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerritorialLevelManager : Manager<TerritorialLevelManager>
{
    public static event Action OnActivateWallsBehaviour = delegate { };

    [SerializeField]
    private float minTimeToNextCall = 0;

    [SerializeField]
    private float maxTimeToNextCall = 0;

    //public List<SignatureColor> colors = new List<SignatureColor>();
    public Dictionary<SignatureColor, int> characterPoints = new Dictionary<SignatureColor, int>();

    public static Dictionary<SignatureColor, Material> pairs = new Dictionary<SignatureColor, Material>();

    [SerializeField]
    private List<Material> materials = new List<Material>();

    private void Start()
    {
        Initialize();

        StartCoroutine(ActivateWallsBehaviour(UnityEngine.Random.Range(minTimeToNextCall, maxTimeToNextCall)));
    }

    protected override void Initialize()
    {
        foreach (SignatureColor color in Enum.GetValues(typeof(SignatureColor)))
        {
            characterPoints.Add(color, 0);
        }

        Array colorsArray = Enum.GetValues(typeof(SignatureColor));

        for (int i = 0; i < colorsArray.Length - 1; i++)
        {
            pairs.Add((SignatureColor)colorsArray.GetValue(i), materials[i]);
        }
    }

    private IEnumerator ActivateWallsBehaviour(float time)
    {
        yield return new WaitForSeconds(time);

        OnActivateWallsBehaviour();
        StartCoroutine(ActivateWallsBehaviour(UnityEngine.Random.Range(minTimeToNextCall, maxTimeToNextCall)));
    }

    public void UpdatePoints(SignatureColor color, int points)
    {
        characterPoints[color] += points;
    }

    public static Material GetMaterial(SignatureColor color)
    {
        return pairs[color];
    }
}
