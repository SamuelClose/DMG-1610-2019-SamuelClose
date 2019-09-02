using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPractice : 
MonoBehaviour
{ 
	
	void update()
	{ 
		if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer>
	().material.color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>
	().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>
	().material.color = Color.blue;
			}
		}
	}

 	//following a tutorial on unity https://learn.unity.com/tutorial/scripts-as-behaviour-components?projectId=5c8920b4edbc2a113b6bc26a#5c8924ededbc2a113b6bc373


	
