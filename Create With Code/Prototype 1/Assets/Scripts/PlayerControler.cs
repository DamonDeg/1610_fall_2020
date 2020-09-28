using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //declare varuables
    public float speed = 10;
    public float turnSpeed = 70f;
    private float horizontalInput = 0;
    private float forwardInput = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //move the vehicle forward
        transform.Translate(0,0,speed * Time.deltaTime * forwardInput);
        
        //turn the vehicle left and right
        transform.Rotate(0,Time.deltaTime * turnSpeed * horizontalInput,0);
    }
}
