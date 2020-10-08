using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

    //declare variables for camera behavior
    public int scrollLimitX = 20, scrollLimitZ = 20;
    private float playerTrackX, playerTrackZ;
    public Vector3 cameraOffset = new Vector3(0, 10, -10);
    public Vector3 cameraPos = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        //sets camera to the player's position
        playerTrackX = player.transform.position.x;
        playerTrackZ = player.transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {

        //follows the player if they go too far to the right
        if (playerTrackX > player.transform.position.x + scrollLimitX)
        {
            playerTrackX = player.transform.position.x + scrollLimitX;
        }
        
        //follows the player if they go too far to the left
        else if (playerTrackX < player.transform.position.x - scrollLimitX)
        {
            playerTrackX = player.transform.position.x - scrollLimitX;
        }
        
        //follows the player if they go too far to the top
        if (playerTrackZ > player.transform.position.z + scrollLimitZ)
        {
            playerTrackZ = player.transform.position.z + scrollLimitZ;
        }
        
        //follows the player if they go too far to the bottom
        else if (playerTrackZ < player.transform.position.z - scrollLimitZ)
        {
            playerTrackZ = player.transform.position.z - scrollLimitZ;
        }
        
        cameraPos = new Vector3(playerTrackX + cameraOffset.x, cameraOffset.y, playerTrackZ + cameraOffset.z);
        transform.position = cameraPos;

    }
}
