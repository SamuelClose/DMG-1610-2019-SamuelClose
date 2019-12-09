using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
   [SerializeField] 
   private Camera cam;
   
   private Vector3 _velocity = Vector3.zero;
   private Vector3 _rotation = Vector3.zero;
   private Vector3 _camRotation = Vector3.zero;
   private float _jump;
   public LayerMask ground;
   public CapsuleCollider cap;
   public float jumpCount;
   public float gravity;
   public float jumpMax;
   private Rigidbody rB;
   private bool IsGrounded()
   {
      jumpCount = 0f;
      var bounds = cap.bounds;
      return Physics.CheckCapsule(bounds.center,
         new Vector3(bounds.center.x, bounds.min.y, bounds.center.z), 
         cap.radius * .8f, ground);
   }
   private void Start()
   {
      rB = GetComponent<Rigidbody>();
   }
   public void Move(Vector3 velocity1) 
   {
      _velocity = velocity1;
   }
   public void Rotate(Vector3 rotate)
   {
      _rotation = rotate;
   }
   public void CamRotate(Vector3 camRot)
   {
      _camRotation = camRot;
   }
   public void JumpSpeed(float jump)
   {
      _jump = jump;
   }
   private void FixedUpdate()
   {
      PerformMovement();
      PerformRotation();
      PerformJump();
   }
   void PerformMovement()
   {
      if (_velocity != Vector3.zero)
      {
         rB.MovePosition(transform.position + _velocity * Time.fixedDeltaTime);
      }
   }
   private void PerformJump()
   {
      if (IsGrounded() && Input.GetKey(KeyCode.Space) && jumpCount < jumpMax)
      {
         rB.AddForce((float) ForceMode.Impulse * _jump * Vector3.up);
         jumpCount ++;
      }
      else
      {
         rB.AddForce(Vector3.down * gravity, ForceMode.Acceleration);
      }
   }
   void PerformRotation()
   {
      rB.MoveRotation(transform.rotation * Quaternion.Euler(_rotation));
      if (cam != null)
      {
         cam.transform.Rotate(-_camRotation);
      }
   }
}
