
using UnityEngine;
[RequireComponent(typeof(PlayerMotor))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float lookSpeed = 5f;
    [SerializeField] private float jumpHeight = 10f;
    private PlayerMotor _movement;
    private void Start()
    {
        _movement = GetComponent<PlayerMotor>();
    }
    private void Update()
    {
        //Calculate movement velocity as a 3d Vector
        float xMovement = Input.GetAxisRaw("Horizontal");
        float zMovement = Input.GetAxisRaw("Vertical");
        Vector3 movementHorizontal = transform.right * xMovement; 
        Vector3 movementVertical = transform.forward * zMovement;
        //Final movement vector
        Vector3 velocity = (movementVertical + movementHorizontal) * moveSpeed;
        //Apply movement
        _movement.Move(velocity);
        
        //Calculate rotation as a 3d Vector, (turning around the y axis, looking left and right)
        float yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 rotation = new Vector3(0f, yRotation, 0f) * lookSpeed;
        //Apply rotation along y-axis
        _movement.Rotate(rotation);

        //Calculate Camera rotation as a 3d Vector, (turning around the y axis, looking up and down)
        float xRotation = Input.GetAxisRaw("Mouse Y");
        Vector3 camRot = new Vector3(xRotation, 0, 0f) * lookSpeed;
        //Apply rotation along y-axis
        _movement.CamRotate(camRot);

        float yMovement = Input.GetAxisRaw("Jump");
        float jump = jumpHeight * yMovement;
        _movement.JumpSpeed(jump);
    }
}


