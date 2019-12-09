//Controller JUST ONE LARGE UPDATE METHOD
using UnityEngine;
[RequireComponent(typeof(PlayerMovement))]
public class PlayerControls : MonoBehaviour
{
    public Animator animator;
    public CharacterController con;
    private PlayerMovement move;
    private float _moveSpeed;
    private float _gravity;
    private int _hops;
    private float _sprint;
    private Vector3 _post;
    private static readonly int Speed = Animator.StringToHash("Speed");

    void Awake()
    {
        animator = GetComponent<Animator>();
        move = GetComponent<PlayerMovement>();
        move.hMove = _moveSpeed;
        move.pos = _post;
        move.lilG = _gravity;
        move.jumpH = _hops;
        move.run = _sprint;
        move.controller = con;
        
    }

    void FixedUpdate()
    {
        _post.x = Input.GetAxisRaw("Horizontal");
        _post.y -= _gravity;
        animator.SetFloat(Speed,_post.x);
        con.Move(Time.fixedDeltaTime * _post);
    }
}