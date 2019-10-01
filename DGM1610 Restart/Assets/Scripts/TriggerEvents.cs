

using System;
using UnityEngine;
using UnityEngine.Events;



public class TriggerEvents : MonoBehaviour
{

   
    public UnityEvent triggerEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
      
    }
    
}












