
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    public CollectionData inventory;
    private void Start()
    {
        inventory = GetComponent<CollectionData>();
        
    }
    

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventory.collectionList.Add(null);
        }
    }
}
       
