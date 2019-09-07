using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
	private int backupMates = 7;

	void Start()
	{
		while (backupMates > 0)
		{
			Debug.Log("Reinforcements");
			backupMates--;
		}
	}
}


/* While Loop: Perform an action WHILE or DURING a condition is met
 for Example 
 
 {
	int cupsInTheSink = 4;
	
	void Start()
	{
		while (cupsInTheSink > 0)
			{
				Debug.log("I have washed a cup");
				cupsInTheSink--;
			}
		}
	}
	
	this code will read out in console 4 times "I have a washed cup because the condition will be met 4 time hence the while statment
	
	
	DoWhileLoop-- test the condition at the end of the body;
	means that the code in the DoWhileLoop will run at least once.
	For Example;
	
	{
		void Start()
		{
			bool shouldContinue = false;
			
			do
			{
				print("Hello World");
			}
			while (shouldContinue == true);
		}
	}
	
	ForLoop-- works by creating a loop with a controllable number of interactions
	checks condition in the loop 
	If a condition is met then it carries out the body
	ANY Operation needed to be done a specific number of time
	can be placed in a ForLoop
	For example
	{
		int numEnemies = 3;
		
		void Start()
		{
			for (int i =0; i < numEnemies; i++)
			{
				Debug.Log("Creating enemy number": + i);
			}
		}
	}

 
 */

