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
    private SphereCollider _sphereCollider;
    private BoxCollider _boxCollider;
    private CharacterController _characterController;
    public Canvas[] canvas;
    private Canvas _canvas;
    private static readonly int  IsJumping = Animator.StringToHash("isJumping");
    private static readonly int Death = Animator.StringToHash("Death");
    private static readonly int IsHurt = Animator.StringToHash("isHurt");
    private static readonly int Speed = Animator.StringToHash("Speed");
    private static readonly int Falling = Animator.StringToHash("Falling");
    private static readonly int IsDead = Animator.StringToHash("isDead");
    private static readonly int Attack = Animator.StringToHash("Attack");
    public Vector3 pos;
    public bool isDead;
    public bool rezTime;
    public bool hurt;
    public float health;
    public float run;
    public float dmgOt = 0-3;
    public float swingTimer;
    public float hMove = 10;
    public float gravity = 10;
    public float jumpH;
    public int jumpC;
    public int jumpCm;
    public int swingC;
    public int swingCm;
    
    public Inventory inventory;
    public Transform itemsParent1;
    public InventorySlot[] slots;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _boxCollider = GetComponent<BoxCollider>();
        _sphereCollider = GetComponent<SphereCollider>();
        _canvas = itemsParent.GetComponent<Canvas>();
        canvas = itemsParent.GetComponentsInChildren<Canvas>();
        animator = GetComponent<Animator>();
        info = GetComponent<PlayerDisplay>();
        controller = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        pos.y -= gravity * Time.fixedDeltaTime;
        health = info.playerHealth;
        if (dmgOt <= 0)
        {
            hurt = false;
            animator.SetBool(IsHurt, false);
        }
        
        if (isDead == true)
        {
            animator.SetBool(IsDead, true);
            animator.SetBool(Death, false);
            _characterController.enabled = false;
            _boxCollider.enabled = false;
            _sphereCollider.enabled = false;
            rezTime = true;
        }
        
        if (swingTimer <= 0)
        {
            animator.SetBool(Attack, false);
        }
        
        
        
        Sprint();
        Jump();
        Swing();

        OpenI();
        CloseI();
        UpdateUI();
        
        Dead();
        DamagedAnimation();
        
        controller.Move(Time.fixedDeltaTime * pos);
    }
    
    private void Sprint()
    {
        pos.x = Input.GetAxisRaw("Horizontal") * run;
        animator.SetFloat(Speed,pos.x);
    }
    private void Jump()
    {
        if (pos.y >= .01)
        {
            animator.SetBool(IsJumping, true);
            animator.SetBool(Falling, false);
        }

        if (pos.y < 0)
        {
            animator.SetBool(Falling, true);
            animator.SetBool(IsJumping, false);
        }
        if (controller.isGrounded)
        {
            pos.y = 0;
            jumpC = 0;
            animator.SetBool(IsJumping, false);
            animator.SetBool(Falling, false);
        } 
        if (Input.GetKeyDown(KeyCode.Space) && jumpC < jumpCm)
        {
            pos.y = jumpH;
            jumpC++;
        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            pos.y -= jumpH;
        }
    }

    private void Swing()
    {
        if (Input.GetKeyDown(KeyCode.M) && swingC < swingCm)
        {
            swingTimer -= Time.fixedDeltaTime;
            Debug.Log("I can Swing my Sword");
            swingC++;
            animator.SetBool(Attack, true);
        }
    }

    void Swung()
    {
        animator.SetBool(Attack, false);
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
    private void OnTriggerEnter(Collider other)
    {
        hurt = true;
    }
    private void Dead()
    {
        if (health <= 0)
        {
            animator.SetBool(Death, true);
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
    
    
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearItem();
            }
        }
    }
}
