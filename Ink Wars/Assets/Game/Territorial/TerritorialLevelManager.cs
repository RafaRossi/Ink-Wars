using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerritorialLevelManager : Manager<TerritorialLevelManager>
{
    public static event Action OnActivateWallsBehaviour;

    [SerializeField]
    private float minTimeToNextCall;

    [SerializeField]
    private float maxTimeToNextCall;

    public Dictionary<SignatureColor, int> characterPoints = new Dictionary<SignatureColor, int>();

    private void Start()
    {
        foreach (SignatureColor color in Enum.GetValues(typeof(SignatureColor)))
        {
            characterPoints.Add(color, 0);
        }

        StartCoroutine(ActivateWallsBehaviour(UnityEngine.Random.Range(minTimeToNextCall, maxTimeToNextCall)));
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
}
