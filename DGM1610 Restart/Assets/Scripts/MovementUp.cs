using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementUp : MonoBehaviour
{
   public UnityEvent jump;


   private void OnMouseDown()
   {
      jump.Invoke();
   }
}
