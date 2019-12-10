//Controller JUST ONE LARGE UPDATE METHOD
using UnityEngine;
[RequireComponent(typeof(PlayerMovement))]
public class PlayerControls : MonoBehaviour
{
    public Animator animator;
    public CharacterController con;
    public PlayerMovement move;
    public float gravity;
    public Vector3 post;
    private static readonly int Speed = Animator.StringToHash("Speed");
    void Awake()
    {
        animator = GetComponent<Animator>();
        move = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        move.pos.x = Input.GetAxisRaw("Horizontal") * move.hMove;
        move.pos.y -= gravity;
        animator.SetFloat(Speed,post.x);
        con.Move(Time.fixedDeltaTime * post);
    }
}