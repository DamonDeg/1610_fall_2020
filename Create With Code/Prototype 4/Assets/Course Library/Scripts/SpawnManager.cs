using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerup;
    public float spawnRange;
    private int enemyCount, waveNum = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    void spawnEnemyWave(int spawnCount)
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            spawnEnemyWave(waveNum);
            waveNum++;
            Instantiate(powerup, GenerateSpawnPos(), powerup.transform.rotation);
        }
    }
    
    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(0, spawnRange);
        float spawnPosZ = Random.Range(0, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
