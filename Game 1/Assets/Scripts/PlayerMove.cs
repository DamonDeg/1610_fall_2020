using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed, jumpStrength, gravity;
    private float xInput, zInput;
    private Vector3 moveDirection = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var trueSpeed = Time.deltaTime * speed;
        xInput = Input.GetAxis("Horizontal") * trueSpeed;
        zInput = Input.GetAxis("Vertical") * trueSpeed;
        moveDirection = new Vector3(xInput, 0f, zInput);
        controller.Move(moveDirection);
    }
}
