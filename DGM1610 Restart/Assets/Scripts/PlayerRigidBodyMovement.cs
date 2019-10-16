using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerRigidBodyMovement : MonoBehaviour
{
   private Vector3 velocity = Vector3.zero;
   public CapsuleCollider cap;
   public LayerMask ground;
   public int jumpCount;
   public int jumpCountMax;
   public float gravity;
   private float _jump;
   private Rigidbody rb;
   private bool isGrounded()
   {
      var bounds = cap.bounds;
      return  Physics.CheckCapsule(bounds.center, new Vector3(bounds.center.x,bounds.min.y, bounds.center.z ), 
         cap.radius * .8f, ground);
   }
   private void Start()
   {
      rb = GetComponent<Rigidbody>();
   }
   public void Move(Vector3 velocity1)
   {
      velocity = velocity1;
   }
   public void Jump(float jump)
   {
      _jump = jump;
   }
   private void FixedUpdate()
   {
      PerformMovement();
      PerformJump();
      void PerformMovement()
      {
         if (velocity != Vector3.zero)
         {
            rb.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
         }
      }
      void PerformJump()
      {
         if (isGrounded() && Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
         {
            rb.AddForce((float) ForceMode.Impulse * _jump * Vector3.up);
            jumpCount++;
         }
         else
         {
            rb.AddForce(Vector3.down * gravity, ForceMode.Acceleration);
         }
      }

   }
}


