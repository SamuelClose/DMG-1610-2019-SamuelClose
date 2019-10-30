using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay1 : MonoBehaviour
{
    public Stats stat;

    public float playerHealth;

    public float playerMagic;

    public float playerMaxHealth;

    public string playerName;
    
    public WeaponData weapon;
    
    public ClothesData shirt;
    
    public ClothesData pants;

    public List<GameArtData> inventory;

    void Start()
    {
        playerHealth = stat.health;

        playerMagic = stat.magic;

        playerMaxHealth = stat.maxHealth;

        playerName = stat.name;

        weapon = stat.weapons;

        shirt = stat.shirt;

        pants = stat.pants;

        inventory = stat.playerInventory;
    }
}

