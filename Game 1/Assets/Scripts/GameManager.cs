using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //global varuables
    public float hungerTickTime = 0.1f;
    public float burgerDelay = 2.5f;
    public float burgerStart = 5;
    
    //Varuables and Game objects for Burger Spawning
    public Transform player;
    private Vector3 spawnPos = new Vector3();
    public float spawnRange;

    //List of Events
    public UnityEvent hungerTick;
    public UnityEvent startGame;
    public UnityEvent spawnBurger;
    
    
    //Sets the clock for the hunger tick
    private IEnumerator HungerTickDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(hungerTickTime);
            hungerTick.Invoke();
        }
    }
    
    //Burger Spawning
    private IEnumerator BurgerSpawnTick()
    {
        yield return new WaitForSeconds(burgerStart);
        while (true)
        {
            yield return new WaitForSeconds(burgerDelay);
            spawnBurger.Invoke();
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        startGame.Invoke();
        StartCoroutine(HungerTickDown());
        StartCoroutine(BurgerSpawnTick());
    }

    public void placeBurger()
    {
        spawnPos.x = player.position.x + (Random.Range(-spawnRange, spawnRange));
        spawnPos.y = player.position.y;
        spawnPos.z = player.position.z + (Random.Range(-spawnRange, spawnRange));
        
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
