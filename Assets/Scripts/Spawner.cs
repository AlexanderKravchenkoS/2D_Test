using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToSpawn;

    private float spawnTime = 0;

    [SerializeField]
    private float minSpawnTime;

    [SerializeField]
    private float maxSpawnTime;

    private void Update() {
        if(Time.time >= spawnTime) {
            var rotation = gameObjectToSpawn.transform.rotation;
            Instantiate(gameObjectToSpawn, transform.position, rotation);
            spawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);

        }
    }

}
