using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public delegate GameObject OnSpawnRequested(GameObject gameObjectS);
    public OnSpawnRequested spawnRequested;

    protected GameObject spawnedObject;

    protected virtual void OnEnable()
    {
        spawnRequested += Spawn;
    }

    protected virtual void OnDisable()
    {
        spawnRequested -= Spawn;
    }

    protected GameObject Spawn(GameObject prefab)
    {
        return Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
