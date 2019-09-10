using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;


public class Class01 : MonoBehaviour
{


	public void OnTriggerEnter(Collider other)
	{
		if () ;
	}

}


// Public allows for editing outside the script as well as accessed by other script
//Private means has to be changed within script
//awake is used before the start function, for example if an enemy has spawned the awake can state the amount of bullets he has, and then he wont shoot till the start function.
// Fixed update will have the same time between each update

