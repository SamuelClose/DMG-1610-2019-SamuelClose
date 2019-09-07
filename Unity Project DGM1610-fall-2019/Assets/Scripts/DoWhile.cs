
using UnityEngine;

public class DoWhile : MonoBehaviour
{
	private void Start()
	{
		const bool shouldContinue = true;

		do
		{
			print("FanX was amaze balls");
		} 
		while (shouldContinue == false);
	}
}


	