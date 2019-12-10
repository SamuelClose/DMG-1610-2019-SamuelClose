using System;
using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;
    public PlayerDisplay info;
    public Transform itemsParent;
    public GameObject newPlayer;
    public Canvas[] canvas;
    private Canvas _canvas;
    private static readonly int  IsJumping = Animator.StringToHash("isJumping");
    private static readonly int Death = Animator.StringToHash("Death");
   private static readonly int IsHurt = Animator.StringToHash("isHurt");
    private static readonly int Speed = Animator.StringToHash("Speed");
    public Vector3 pos;
    public bool isDead;
    public bool hurt;
    public float dmgOt = 0-3;
    public float resTimer;
    public float hMove = 10;
    public float gravity = 10;
    public float jumpH;
    public int jumpC;
    public int jumpCm;
    public float health;
    
    public float run;
    private void Awake()
    {
        _canvas = itemsParent.GetComponent<Canvas>();
        canvas = itemsParent.GetComponentsInChildren<Canvas>();
        animator = GetComponent<Animator>();
        info = GetComponent<PlayerDisplay>();
        controller = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        pos.y -= gravity * Time.deltaTime;
        health = info.playerHealth;
        if (dmgOt <= 0)
        {
            hurt = false;
            animator.SetBool(IsHurt, false);
        }
        Walk();
        OpenI();
        CloseI();
        Jump();
        Crouch();
        Sprint();
        Dead();
        DamagedAnimation();
        controller.Move(Time.fixedDeltaTime * pos);
    }

    private void Walk()
    {
        pos.x = Input.GetAxisRaw("Horizontal") * hMove;
        animator.SetFloat(Speed,pos.x);
    }

    private void Jump()
    {
        if (controller.isGrounded)
        { 
            pos.y = 0;
            jumpC = 0;
        } 
        if (Input.GetKeyDown(KeyCode.Space) && jumpC < jumpCm)
        {
                pos.y = jumpH + 10;
                jumpC++;
                animator.SetBool(IsJumping, true);  
        }
    }
    private void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftCommand))
        {
            
        } 
    }
    private void OpenI()
    { 
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _canvas.enabled = true;
        }
    }
    private void CloseI()
    { 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _canvas.enabled = false;
        }  
    }
    private void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
                   
        }
    }
    
    public void SpawnPlayer()
    {
         newPlayer = Instantiate(newPlayer);
    } 
    
    private void OnTriggerEnter(Collider other)
    {
        hurt = true;
    }

    public void Dead()
    {
        if (health <= 0)
        {
            animator.SetBool(Death, true);
            Destroy(gameObject, resTimer); 
            isDead = true;
        }
    }
    private void DamagedAnimation()
    {
        if (hurt)
        {
            dmgOt -= Time.fixedDeltaTime;
            animator.SetBool(IsHurt, true);
        }
    }
    
    
    
    
    
    
    
    /*public void Respawn()
    {
        if (isDead)
        {
            SpawnPlayer();
        }
    */
}
