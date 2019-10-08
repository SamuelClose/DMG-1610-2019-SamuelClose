using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{

   [SerializeField] 
   private Camera cam;
   
   private Vector3 velocity = Vector3.zero;
   private Vector3 rotation = Vector3.zero;
   private Vector3 camRotation = Vector3.zero;
   
   private Rigidbody rB;
   
   private void Start()
   {
      rB = GetComponent<Rigidbody>();
   }
  
   public void Move(Vector3 _velocity) 
   {
      velocity = _velocity;
   }
  
   public void Rotate(Vector3 rotate)
   {
      rotation = rotate;
   }
   
   public void camRotate(Vector3 camRot)
   {
      camRotation = camRot;
   }
  
   private void FixedUpdate()
   {
      PerformMovement();
      PerformRoation();
   }
  
   void PerformMovement()
   {
      if (velocity != Vector3.zero)
      {
         rB.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
      }
   }

   void PerformRoation()
   {
      rB.MoveRotation(transform.rotation * Quaternion.Euler(rotation));
      if (cam != null)
      {
         cam.transform.Rotate(-camRotation);
      }
   }
}
