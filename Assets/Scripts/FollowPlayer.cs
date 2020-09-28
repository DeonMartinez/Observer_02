using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    //a Vector3 stores 3 flaots
    public Vector3 offset;


    
    void Update()
    {
        //transform with a lowercase t references the local object the script is attached to, in this case the camera
        transform.position = player.position + offset;
       

    }
}
