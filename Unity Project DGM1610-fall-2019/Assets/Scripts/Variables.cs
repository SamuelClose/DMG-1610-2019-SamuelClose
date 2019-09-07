using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class Variables : MonoBehaviour
{
	//Float numbers require a f after the numeral
	//int do not need f after it 
	public float floatValue = 5.5f;
	private int intValue = 20;
	public string stringValue = "Bob";
	public int firepower;
	public UnityEvent Event;

	private void Start()
	{
		{
			intValue = 33;
			Debug.Log(intValue * 2);
		}
		
		{
			/*
			Debug.Log(transform.position.x);
			
			if (transform.position.y <= 5f)
			{
				Debug.Log("BANZAI");
			}
			*/
		}
		
	}


	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	
	}
	
	
}
