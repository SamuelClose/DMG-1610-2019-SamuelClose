using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplay : MonoBehaviour
{
   public Item stats;
   public new string name;
   public bool isDefault;


   private void Start()
   {
      name = stats.name;
      isDefault = stats.isDefaultItem;
   }
}
