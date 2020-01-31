using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObjectPrefab;
    public Transform spawnCenter;
    public float spawnRadius;
    public float spawnPerSeconds;

    private void Start()
    {
        StartCoroutine(SpawnSystem());
    }

    IEnumerator SpawnSystem()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(0, spawnRadius), Random.Range(0, spawnRadius));
        Instantiate(spawnObjectPrefab, randomSpawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(spawnPerSeconds);
    }
}
