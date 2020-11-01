using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;
    private GameManager gameManager;
    public ParticleSystem explosionParticle;

    public int pointValue;

    private float minSpeed=12, maxSpeed=16, maxTorque=10, xRange=4, ySpawnPos=-1;
    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        targetRB.AddForce(randomForce(), ForceMode.Impulse);
        targetRB.AddTorque(randomTorque(), randomTorque(), randomTorque(), ForceMode.Impulse);
        transform.position = randomSpawnPos();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            gameManager.updateScore(pointValue);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if(!gameObject.CompareTag("Bad")) {gameManager.GameOver();}
    }
    
    Vector3 randomForce()
    {
        ;
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float randomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    
    Vector3 randomSpawnPos()
    {
        ;
        return new Vector3(Random.Range(-xRange,xRange), ySpawnPos);
    }
}
