using System;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Vector3 position;
    private CharacterController controller;
    public float moveSpeed, gravity, jumpHeight;
    public int jumpCount;
    public int jumpCountMax;
    public Inventory inventory;
    public Transform itemsParent;

    private InventorySlot[] slots;

    void Start()
    {
        controller = GetComponent<CharacterController>();
       inventory = Inventory.instance;
       inventory.onItemChangedCallBack += UpdateUI;
       slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }
    void FixedUpdate()
    {
       position.x = moveSpeed * Input.GetAxisRaw("Horizontal");
       position.y -= gravity * Time.fixedDeltaTime;
       animator.SetFloat("Speed", Mathf.Abs(position.x));
        
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
      
        controller.Move(position * Time.deltaTime);
        
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(Inventory.instance);

            Debug.Log("Inventory open");
            
        }

        if (Input.GetKey(KeyCode.I))
        {
            
            Debug.Log("Inspecting Inventory");
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
