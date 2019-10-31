using System;
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using Vector3 = System.Numerics.Vector3;
 
 public class PLayerRigidBodyController : MonoBehaviour
 {
   [SerializeField] private float moveSpeed;
   [SerializeField] private float jumpHeight;
 
   private PlayerRigidBodyMovement _movement;
   private void Start()
   {
     GetComponent<PlayerRigidBodyMovement>();
   }
 
 
   private void Update()
   {
     float xMove = Input.GetAxisRaw("Horizontal");
     float yMove = Input.GetAxisRaw("Jump");
    UnityEngine.Vector3 moveHor = transform.right * xMove;
    UnityEngine.Vector3 velocity = moveHor * moveSpeed;
     
     _movement.Move(velocity);
 
     float jump = jumpHeight * yMove;
     _movement.Jump(jump);
 
 
   }
 }
