using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : SpawnPoint
{
    private GameObject player;

    protected override void OnEnable()
    {
        base.OnEnable();

        SpawnManager.Instance.initializePlayerPrefab += SpawnPlayer;
    }

    protected override void OnDisable()
    {
        base.OnDisable();

        SpawnManager.Instance.initializePlayerPrefab -= SpawnPlayer;
    }

    private void SpawnPlayer(GameObject prefab, PlayerID playerID)
    {
        player = spawnRequested(prefab);
        player.GetComponent<CharacterBase>().PlayerID = playerID;
    }

    private void RespawnPlayer(GameObject player)
    {
        player.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
    }
}
