

using System;
using UnityEngine;
using UnityEngine.Events;



public class TriggerEvents : MonoBehaviour
{

   
    public UnityEvent triggerEventEnter;
    public UnityEvent triggerEventStay;
    public UnityEvent triggerEventExit;

    public void OnTriggerEnter(Collider other)
    {
        triggerEventEnter.Invoke();
      
    }

    public void OnTriggerStay(Collider other)
    {
        triggerEventStay.Invoke();
    }

    public void OnTriggerExit(Collider other)
    {
        triggerEventExit.Invoke();
    }
}












