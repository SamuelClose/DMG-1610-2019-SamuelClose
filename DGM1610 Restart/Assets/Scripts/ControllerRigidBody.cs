using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]

public class ControllerRigidBody : MonoBehaviour
{
    public float jumpCount;

    public float jumpCountMax = 2f;
    
    public LayerMask groundLayers;

    public CapsuleCollider cap;
    
    private string moveInputAxis = "Vertical";
    
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360f;
    
    public float moveSpeed = 10f;

    public float jumpSpeed = 10f;

    public float gravity = 9.5f;

    private Rigidbody rb;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cap = GetComponent<CapsuleCollider>();
    }


   

    void FixedUpdate()
    
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        

        ApplyInput(moveAxis, turnAxis);
        
      
       
        rb.AddForce(Vector3.down * gravity, ForceMode.Acceleration);
        
        
        
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            jumpCount++;
        }
    }

    private bool IsGrounded()
    {
        jumpCount = 0;
        
        return Physics.CheckCapsule(cap.bounds.center,
            new Vector3(cap.bounds.center.x, cap.bounds.min.y, cap.bounds.center.z), cap.radius * .9f, groundLayers);
        
    }

    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }


    private void Move(float input)
    {
        rb.AddForce(moveSpeed * input * transform.forward, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}






