//Movement or Motors do all the heavy lifting, setting up all of the functions and statements
// IF STATEMENTS HERE
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;
    private Rigidbody _rB;
    public PlayerDisplay info;
    public Collider Col;
    private static readonly int  IsJumping = Animator.StringToHash("isJumping");
    private static readonly int Death = Animator.StringToHash("Death");
    private static readonly int IsHurt = Animator.StringToHash("isHurt");
    public Vector3 pos;
    public bool isDead;
    public bool hurt;
    public float dmgOt;
    public float resTimer;
    public float hMove;
    public float lilG;
    public float jumpH;
    public int jumpC;
    public int jumpCm;
    public float health;
    public float run;
    private GameObject prefab;
    public GameObject newPlayer;
    public Canvas _canvas;

    private void Awake()
    {
        _canvas = GetComponent<Canvas>();
        animator = GetComponent<Animator>();
        info = GetComponent<PlayerDisplay>();
        controller = GetComponent<CharacterController>();

    }
    private void FixedUpdate()
    {
        OpenI();
        CloseI();
        health = info.playerHealth;
        //OnTriggerEnter(Col);
        //dmgOt -= Time.fixedDeltaTime;
        Reborn();
        Jump();
        Crouch();
        Sprint();
        Dead();
        Restore();
    }

    private void Jump()
    {
        if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space) && jumpC < jumpCm)
        {
            pos.y = jumpH;
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
    private void SpawnPlayer()
    {
         newPlayer = Instantiate(prefab);
    } 
    
    private void OnTriggerEnter(Collider other)
    {
        Damaged();
    }
    private void Dead()
    {
        if (health <= 0)
        {
            animator.SetBool(Death, true);
            Destroy(gameObject, resTimer); 
            isDead = true;
        }
    }
    private void Damaged()
    {
        hurt = true;
        if (hurt)
        {
            animator.SetBool(IsHurt, true);
        }
    }
    private void Restore()
    {
        if (dmgOt <= 0)
        {
            animator.SetBool(IsHurt, false);
        }
    }
    private void Reborn()
    {
        if (isDead)
        {
            SpawnPlayer();
        }
    }
}
