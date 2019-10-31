using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponPickup : MonoBehaviour
{
    public PlayerDisplay1 stat;
    public List<GameArtData> weapons;
 
    private void Start()
    {
        weapons = stat.inventory;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
             StartCoroutine(routine:Pickup(other));
        } 
    }
    IEnumerator Pickup(Collider other)
    {
        void AddItem(GameArtData obj)
        {
            for (int i = 0; i < weapons.Count; i++)
            {
                if (weapons.Contains(obj))
                {
                    weapons.Add(obj);
                }
            }
        }
        
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        yield return other ;
    }
}