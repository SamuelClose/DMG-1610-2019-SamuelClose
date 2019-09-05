using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Variables : MonoBehaviour
{
	//Float numbers require a f after the numeral
	//int do not need f after it 
	public float floatValue = 5.5f;
	public int intValue = 20;
	public string stringValue = "Bob";
	public int firepower;
	public UnityEvent Event;


	private void OnTriggerEnter (Collider other) {
		Destroy(gameObject);     
	}


	// Use this for initialization 

	}
	

	// Update is called once per frame
	

