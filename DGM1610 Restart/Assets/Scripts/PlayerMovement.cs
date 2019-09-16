using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; //Reference to the Rigid body component called "rb"
  

    void FixedUpdate() //When using physics use FixedUpdate
    {
        if (Input.GetKeyDown("w"))
        {
            
        }
    }
    }





/* if (Input.GetKey("w"))
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
}*/
    
 