using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnManager : Manager<SpawnManager>
{
    public delegate void OnSpawnRequest(GameObject prefab);

    public OnSpawnRequest initializePlayerPrefab = delegate { };
    public OnSpawnRequest respawnPlayer = delegate { };

    public GameObject playerPrefab;
}
