using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public int space = 12;
    
    public List<Item> items = new List<Item>();

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one found");
            return;
        }
        instance = this;
    }

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;
    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room");
                return false;
            }
            items.Add(item);

            onItemChangedCallBack?.Invoke();
        }
        return true;
    }
    public void Remove(Item item)
    {
        items.Remove(item);

        onItemChangedCallBack?.Invoke();

    }
}
