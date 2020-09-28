using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float thingPoint = 0f;
    public bool isDoinTheThing = false;

    
    
    
    public CharacterController controller;
    public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    
    
    private Vector3 moveDirection;
    private float yDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void theThing()
    {

        isDoinTheThing = true;

    }
    
    // Update is called once per frame
    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;

        yDirection += gravity * Time.deltaTime;
        if (controller.isGrounded)
        {

            yDirection = -0.1f;
            
            if (Input.GetButtonDown("Jump"))
            {

                yDirection = jumpForce;

            }

        }

        moveDirection.Set(moveSpeedInput,yDirection,0);
        controller.Move(moveDirection);
        
        if (isDoinTheThing)
        {
            thingPoint = thingPoint + 1;
            print("he doin' the thing! :D");
            
            transform.Rotate(0, 0, thingPoint*Time.deltaTime);
            transform.localScale = new Vector3(1f + thingPoint * Time.deltaTime, 1f, 1f);
        }

        


    }

}