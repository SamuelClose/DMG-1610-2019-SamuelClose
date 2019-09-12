using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class DogClass : MonoBehaviour
{

   public UnityEvent doesStuff;
   
   
   private void OnMouseDown()
   {   
      doesStuff.Invoke();
   }
}
