using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTagFollow : MonoBehaviour
{
    // Declaring da varuables
    public float height;
    public Transform entityPos;
    private Vector3 newPos;

    // Update is called once per frame
    void Update()
    {
        newPos.x = entityPos.position.x;
        newPos.y = entityPos.position.y + height;
        newPos.z = entityPos.position.z;

        transform.position = newPos;
    }
}
