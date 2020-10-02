using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public int topLimit = 50;
    public int bottomLimit = -50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topLimit)
        {
            Destroy(gameObject);
        }
        
        else if (transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
