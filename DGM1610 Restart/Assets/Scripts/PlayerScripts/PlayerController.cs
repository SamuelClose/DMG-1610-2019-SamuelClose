using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;
    public float moveSpeed, gravity, jumpHeight;
    public int jumpCount;
    public int jumpCountMax ;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        position.x = moveSpeed * Input.GetAxisRaw("Horizontal");
        position.y -= gravity;
        
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
        {
            position.y = jumpHeight;
            jumpCount++;
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                position.y -= jumpHeight;
            }
        }
        controller.Move(position * Time.deltaTime);
    }
}
