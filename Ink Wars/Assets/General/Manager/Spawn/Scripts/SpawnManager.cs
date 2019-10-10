using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnManager : Manager<SpawnManager>
{
    public delegate void OnSpawnRequest(GameObject prefab, PlayerID playerID);

    public OnSpawnRequest initializePlayerPrefab = delegate { };
    public OnSpawnRequest respawnPlayer = delegate { };

    public GameObject playerPrefab;

    private void Start()
    {
        Initialize();
    }

    protected override void Initialize()
    {
        Array playerIdArrays = Enum.GetValues(typeof(PlayerID));

        for (int i = 0; i < playerIdArrays.Length; i++)
        {
            initializePlayerPrefab(playerPrefab, (PlayerID)playerIdArrays.GetValue(i));
        }
    }
}
