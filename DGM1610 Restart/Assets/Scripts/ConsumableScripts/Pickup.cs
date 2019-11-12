using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
   public Item item;
  
   void PickUp()
   {
      Inventory.instance.Add(item);
      Destroy(gameObject);
   }

   public void OnTriggerEnter(Collider other)
   {
      PickUp();
   }
}
