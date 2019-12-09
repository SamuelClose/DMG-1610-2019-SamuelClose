using UnityEngine;
using UnityEngine.UI;

    

public class InventorySlot : MonoBehaviour
{

    public Image icon;
    public Item item;
    public void AddItem(Item item)
    {
        item = ScriptableObject.CreateInstance<Item>();

        icon.sprite = item.icon;
        icon.enabled = true;
    }
    public void ClearItem()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }


}
