using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private Vector3 position;
    
    private CharacterController controller;
    
    public float moveSpeed, gravity, jumpSpeed, jumpHeight;
    
    public int jumpCount;
    
    public int jumpCountMax ;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        position.x = moveSpeed * Input.GetAxisRaw("Horizontal");
        
        position.y = jumpSpeed * Input.GetAxisRaw("Vertical");

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
            {
                position.y -= gravity;
                
            }
        }

        controller.Move(position * Time.deltaTime);
    }
}
