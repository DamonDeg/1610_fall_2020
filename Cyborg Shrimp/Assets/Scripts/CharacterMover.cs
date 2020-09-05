using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float thingPoint = 0f;

    public bool isDoinTheThing = false;
    public Vector3 iHateThis = new Vector3(1f,1f,1f);
    
    // Start is called before the first frame update
    void Start()
    {

    }

    public void theThing()
    {

        isDoinTheThing = true;

    }
    
    // Update is called once per frame
    void Update()
    {

        if (isDoinTheThing)
        {
            thingPoint = thingPoint + 1;
        }

        transform.Rotate(0, 0, thingPoint*Time.deltaTime);
        transform.localScale = new Vector3(1f + thingPoint * Time.deltaTime,1f,1f);
        print("he doin' the thing! :D");


    }

}