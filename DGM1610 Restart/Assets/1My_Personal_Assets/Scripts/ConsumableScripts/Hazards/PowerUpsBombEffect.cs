
using System;
using System.Collections;
using System.IO;
using UnityEngine;
public class PowerUpsBombEffect : MonoBehaviour
{
    public int damage = 10;
    public PlayerDisplay stats;
    public float health;
    
   

    public void Awake()
    {
        GetComponent<PlayerDisplay>();
    }
    private void Update()
    {
        health = stats.playerHealth;
    }
    private void OnTriggerEnter(Collider other)
 {
     if (other.CompareTag("Player"))
     {
        
         StartCoroutine(Pickup (other));
     }
     IEnumerator Pickup (Collider player)
     {
         health -= damage;
         GetComponent<SpriteRenderer>().enabled = false;
         GetComponent<SphereCollider>().enabled = false;
         return null;
     }
 }
    
}
