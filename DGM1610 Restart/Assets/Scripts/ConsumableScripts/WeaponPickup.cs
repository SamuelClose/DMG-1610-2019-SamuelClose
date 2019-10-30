using System;
using System.Collections;
using UnityEngine;
public class WeaponPickup : MonoBehaviour
{
    public PlayerDisplay1 stat;

    private void Start()
    {
       
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
             StartCoroutine(routine:Pickup(other));
        } 
    }
    IEnumerator Pickup(Collider player)
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        
        void AddData(GameArtData obj)
        {
            for (int i = 0; i < stat.inventory.Count; i++)
            {
                if (stat.inventory.Contains(obj))
                {
                    stat.inventory.Add(obj);
                }
            }
        }
        yield return player;
    }
}
