using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameArtData
{



    public void SpawnPlayer()
         {
             var newPlayer = Instantiate(prefab);
             var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
             newSprite.sprite = sprite;
             newSprite.color = color;
         }
    
    
    
    
}
