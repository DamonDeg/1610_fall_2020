using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDaCubes : MonoBehaviour
{
    public GameObject daCube;
    public int clusterSize;
    public float clusterSpread;
    private Vector3 placePos = new Vector3();

    // Update is called once per frame
    void Update()
    {
        //makes a cluster of cubes based on the var clusterSize
        for(int i=0; i<clusterSize; i++)
        {
            //chooses a random spot
            placePos.x = transform.position.x + (Random.Range(-clusterSpread, clusterSpread));
            placePos.y = transform.position.y + (Random.Range(-clusterSpread, clusterSpread));
            placePos.z = transform.position.z + (Random.Range(-clusterSpread, clusterSpread));
            
            //places the cube
            Instantiate(daCube, placePos, daCube.transform.rotation);
        }
    }
}
