using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed = 5, boundaryLeft = -10, boundaryRight = 10;
    private Vector3 moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //move the player
        moveSpeed.Set(Input.GetAxis("Horizontal")*Time.deltaTime*playerSpeed, 0, 0);
        controller.Move(moveSpeed);

        //keep the player in bounds
        if (transform.position.x <= boundaryLeft)
        {

            transform.position = new Vector3(boundaryLeft,0,0);

        }
        
        if (transform.position.x >= boundaryRight)
        {

            transform.position = new Vector3(boundaryRight,0,0);

        }


    }
}
