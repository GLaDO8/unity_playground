using UnityEngine;

public class playermovement : MonoBehaviour
{
    //create a rigid body object to refer that component in Unity. 
    // Create the object and then drag and drop the Rigidbody component of
    //whichever object you want to refer. 
    public Rigidbody rb;
    public float force = 100f;
    // Start is called before the first frame update
    //NOTE - in C# (C sharp) it doesn't matter how many spaces are thwere between delimiters
    //runs when the game starts
    //void Start()
    //{
    //    //Display a message
    //    //Debug.Log("My first game!"); 

    //    //rb.useGravity = false;
    //    rb.AddForce(0, 200, 400);
    //}

    // Update is called once per frame
    //But the issue is calling this once a frame will call it many times 
    //on a faster computer and slowly on a slower computer.
    //time.deltatime is the time taken to render each frame. higher the frame rate, lower this value. 
    //use FixedUpdate instead of update if we use update for physics. 
    void FixedUpdate()
    {
        //rb.AddForce(0,0, ForwardForce * Time.deltaTime);

        //adding plauyer movement
        if (Input.GetKey("d")){
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);

        }
        Debug.Log(transform.position);    
        }
}
