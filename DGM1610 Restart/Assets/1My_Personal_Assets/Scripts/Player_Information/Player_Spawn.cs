using System;
using UnityEngine;
public class Player_Spawn : MonoBehaviour
{
    public GameObject newPlayer;
    private void Awake()
    {
        SpawnPlayer();
    }
    
    private void FixedUpdate()
    {
        //Respawn();
    }
    private void SpawnPlayer()
    {
        {
            newPlayer = Instantiate(newPlayer);
        }
    }
   
    
}
