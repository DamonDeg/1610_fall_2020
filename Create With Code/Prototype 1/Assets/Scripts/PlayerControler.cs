using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 5f;
    public float horizontalInput = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //move the vehicle forward
        transform.Translate(0,0,speed * Time.deltaTime);
        transform.Translate(Time.deltaTime * turnSpeed * horizontalInput,0,0);
    }
}
