using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody enemyRb;
    private GameObject player;
    
    public float speed, despawnLimit;

    private Vector3 lookDirection;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = (player.transform.position - transform.position).normalized * speed;
        enemyRb.AddForce(lookDirection);
        if (transform.position.y < -despawnLimit)
        {
            Destroy(gameObject);
        }
        
    }
}
