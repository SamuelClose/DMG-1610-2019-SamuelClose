using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public Stats stat;

    public float playerHealth;

    public float playerMagic;

    public float playerMaxHealth;
    
    

    
    
    void Start()
    {
      playerHealth = stat.health;

      playerMagic = stat.magic;

      playerMaxHealth = stat.maxHealth;
      
      
    }

    public void FixedUpdate()
    {
       
    }
}
