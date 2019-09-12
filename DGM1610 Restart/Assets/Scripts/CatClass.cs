using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CatClass : MonoBehaviour
{
   
    public UnityEvent lightOff;
    public UnityEvent lightOn;

    private void OnMouseDown()
    {
        lightOff.Invoke();
    }

    private void OnMouseUp()
    {
        lightOn.Invoke();
    }
}
