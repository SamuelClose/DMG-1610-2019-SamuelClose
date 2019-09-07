using UnityEngine;

public class ForLoop : MonoBehaviour
{
	private int numEnemies = 4;

	private void Start()
	{
		for (var i = 0; i < numEnemies; i++)
		{
			Debug.Log("ENEMIES" + i);
		}
	}
}

	