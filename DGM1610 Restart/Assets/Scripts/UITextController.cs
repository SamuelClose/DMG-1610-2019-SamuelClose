using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// SAME DATA TYPE
//STRING IS FOR TEXT


[RequireComponent(typeof(Text))]

public class UITextController : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text textLabel;

    public void UpdateText(IntDataObject data)
    {
        textLabel.text = data.value.ToString();
    }


    void Start()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }
}
