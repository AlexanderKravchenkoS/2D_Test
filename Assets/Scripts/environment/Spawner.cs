using UnityEngine;
namespace environment {
    public class Spawner : MonoBehaviour {

        [SerializeField]
        private GameObject[] gameObjectToSpawn;

        private float spawnTime = 0;

        [SerializeField]
        private float minSpawnTime;

        [SerializeField]
        private float maxSpawnTime;

        private void Update() {
            if (Time.time >= spawnTime) {
                var enemy = gameObjectToSpawn[Random.Range(0, gameObjectToSpawn.Length)];

                var rot = enemy.transform.rotation;
                var pos = new Vector3(transform.position.x, enemy.transform.position.y, 0);

                Instantiate(enemy, pos, rot);

                spawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
            }
        }
    }
}

