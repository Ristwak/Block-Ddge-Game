using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockprefab;
    public float timeBetweenWaves = 1f;
    public float timeToSpawn = 2f;
    // Update is called once per frame
    private void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(blockprefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
