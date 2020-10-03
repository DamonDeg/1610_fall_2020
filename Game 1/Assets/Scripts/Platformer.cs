using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    public CharacterController controller;
    public float speed, jumpStrength, gravity, weeSpeed;
    public float xInput, zInput, ySpeed;
    private Vector3 moveDirection = new Vector3();
    public AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        var trueSpeed = Time.deltaTime * speed;
        
        // move on the ground
        xInput = Input.GetAxis("Horizontal") * trueSpeed;
        zInput = Input.GetAxis("Vertical") * trueSpeed;

        // platforming mechanics yes
        ySpeed += gravity*Time.deltaTime;
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump();
            }
            else
            {
                ySpeed = -1;
            }
        }

        // move the player after all calculations
        moveDirection = new Vector3(xInput, ySpeed, zInput);
        controller.Move(moveDirection);
        
        // do the weeee
        if (Input.anyKeyDown)
        {
            transform.Rotate(0,weeSpeed,0);
        }
    }

    // platforming mechanics go brrrrrrrrrr
    private void jump()
    {
        ySpeed = jumpStrength + Random.Range(-(jumpStrength / 4), (jumpStrength / 4));
        jumpSound.Play();
    }
    
}
