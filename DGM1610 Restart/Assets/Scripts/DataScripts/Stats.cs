using System;
using System.Collections.Generic;

using UnityEngine;
[CreateAssetMenu(fileName = "New Stats", menuName = "Stat")]
public class Stats : GameArtData
{
    public new string name;
    public int health;
    public int magic;
    public int maxHealth;
    public WeaponData weapons;
    public ClothesData shirt;
    public ClothesData pants;
    public List<GameArtData> playerInventory;


    private void Awake()
    {
        playerInventory = new List<GameArtData>(4);
    }

    public void SpawnPlayer()
             {
                 var newPlayer = Instantiate(prefab);
                 var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
                 newSprite.sprite = sprite;
                 newSprite.color = color;
             }


}
