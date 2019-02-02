using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false;
        }

    }

}
