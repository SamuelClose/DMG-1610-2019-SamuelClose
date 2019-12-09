using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
   public Item item;
  
   void PickUp()
   {
      bool wasPickedUp = Inventory.instance.Add(item);
      if (wasPickedUp)
      {
         Destroy(gameObject);
      }
   }

   public void OnTriggerEnter(Collider other)
   {
      PickUp();
   }
}
