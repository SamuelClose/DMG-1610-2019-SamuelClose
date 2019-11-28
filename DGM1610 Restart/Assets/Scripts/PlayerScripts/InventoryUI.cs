using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Analytics;

public class InventoryUI : MonoBehaviour
{
    private Inventory inventory;

    public Transform itemsParent;

    private InventorySlot[] slots;

        private void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
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
