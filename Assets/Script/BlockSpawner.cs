
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockprefab;
    public float timeBetweenWaves = 1f;
    public float timeToSpawn = 2f;

    private void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    private void SpawnBlocks()
    {
        if (spawnPoints == null || spawnPoints.Length == 0)
            return;

        if (blockprefab == null)
        {
            Debug.LogWarning("Block prefab is not assigned.", this);
            return;
        }

        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i == randomIndex || spawnPoints[i] == null)
                continue;

            Instantiate(
                blockprefab,
                spawnPoints[i].position,
                Quaternion.identity
            );
        }
    }
}

