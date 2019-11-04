using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponPickup : MonoBehaviour
{
    public List<GameArtData> collectionList;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
             StartCoroutine(routine:Pickup(other));
        } 
    }
    IEnumerator Pickup(Collider other)
    {
        
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
      
        yield return other ;
        AddData(null);
    }

   

    private void AddData(GameArtData obj)
    {
        for (int i = 0; i < collectionList.Count; i++)
        {
            if (collectionList.Contains(obj))
            {
                collectionList.Remove(obj);
            }
        }
    }
    
}