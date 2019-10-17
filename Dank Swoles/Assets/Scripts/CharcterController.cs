using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterController : MonoBehaviour
{
    public float rollSpeed;
    public float moveSpeed;
    private Rigidbody2D _rb;
    private Vector2 moveX;
    void Start()
   
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveX = moveInput * moveSpeed;
    }
    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + moveX * Time.fixedDeltaTime);
        
        
    }
}
