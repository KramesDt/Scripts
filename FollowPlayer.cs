using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //camera offset is saved in a private variable
    private Vector3 offset = new Vector3(0, 5, -9);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera behing the player by adding to the camera's position
        transform.position = player.transform.position + offset;
    }
}
