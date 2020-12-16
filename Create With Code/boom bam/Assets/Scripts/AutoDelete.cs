using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDelete : MonoBehaviour
{
    private int destroyTimer = 1;
    // Start is called before the first frame update
    void Update()
    {
        if (destroyTimer <= 0)
        {
            Destroy(gameObject);
        }
        destroyTimer--;
    }
    
}
