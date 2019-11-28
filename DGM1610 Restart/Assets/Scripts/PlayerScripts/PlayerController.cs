using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private Vector3 position;
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
        
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(Inventory.instance);

            Debug.Log("Inventory open");
            
        }

        if (Input.GetKey(KeyCode.I))
        {
            
            Debug.Log("Inspecting Inventory");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            
           
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
