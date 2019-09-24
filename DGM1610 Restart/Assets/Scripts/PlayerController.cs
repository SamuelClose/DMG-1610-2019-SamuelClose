using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMaz = 2;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.y -= gravity;

        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMaz)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }

        controller.Move(position * Time.deltaTime);
    }
}
