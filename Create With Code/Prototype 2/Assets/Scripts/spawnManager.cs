using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;

    public int spawnRangeX = 20;
    public int spawnPosZ = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0,animalPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        }
    }
}
