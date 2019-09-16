using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GravityStart : MonoBehaviour
{
   public UnityEvent drop;


   private void OnMouseDown()
   {
      drop.Invoke();
   }
}
