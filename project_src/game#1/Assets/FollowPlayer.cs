using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //display position
        //tranform with small t is the transform of the object this script is attached to
        transform.position = player.position + offset;
    }
}
