using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;    //Reference to the Rigid body component called "rb"

    public float forewardForce = 500f;
    public float sidewaysForce = 500f;
    public float backwardsForce = 500f;
    void FixedUpdate()    //When using physics use FixedUpdate
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forewardForce * Time.deltaTime);

        }
        
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0 );
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0 );
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-backwardsForce * Time.deltaTime );
        }
    }
}
 