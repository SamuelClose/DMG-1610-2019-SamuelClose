
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsBombEffect : MonoBehaviour
{
    public int damage = 10;
    public PlayerDisplay stats;
    public void Awake()
    {
        stats = GetComponent<PlayerDisplay>();
    }

    private void OnTriggerEnter(Collider other)
    {
        stats.playerHealth -= damage;
    }


   
       
}
   

