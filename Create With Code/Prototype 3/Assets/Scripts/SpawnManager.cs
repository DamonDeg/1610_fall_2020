using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    public float startDelay = 2, repeatRate = 2;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    private PlayerController playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstical", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstical()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
        }
    }
}
