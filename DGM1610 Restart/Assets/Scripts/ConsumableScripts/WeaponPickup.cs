using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public PlayerDisplay1 stat;
    public GameObject prefab;
    public List<GameArtData> collectionList;
   
    private void Awake()
    {
        stat.inventory = collectionList;
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
        void AddData(GameArtData obj)
        {
            for (int i = 0; i < collectionList.Count; i++)
            {
                if (collectionList.Contains(null))
                {
                    collectionList.Add(obj);
                }
            }
        }
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        yield return true;
    }

   
}
