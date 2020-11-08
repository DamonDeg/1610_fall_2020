using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //global varuables
    public float hungerTickTime;
    
    //List of Events
    public UnityEvent hungerTick;
    public UnityEvent startGame;
    
    //Sets the clock for the hunger tick
    private IEnumerator HungerTickDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            hungerTick.Invoke();
        }
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        startGame.Invoke();
        StartCoroutine(HungerTickDown());
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
