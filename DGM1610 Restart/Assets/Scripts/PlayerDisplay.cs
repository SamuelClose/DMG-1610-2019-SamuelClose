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

    public float playerDamage;

    public string playerName;

    void Start()
    {
      playerHealth = stat.health;

      playerMagic = stat.magic;

      playerMaxHealth = stat.maxHealth;

      playerName = stat.name;

     stat.SpawnPlayer();
    }
}
