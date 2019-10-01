using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PowerUpsBombEffect : MonoBehaviour
{
    
    public float damage = 1f;
    public float time = 25f;

 private void OnTriggerEnter(Collider other)
 {
     if (other.CompareTag("Player"))
     {
         StartCoroutine(Pickup (other));
     }

     IEnumerator Pickup (Collider player)
     {
         PlayerHealth stats = player.GetComponent<PlayerHealth>();
         stats.health = -damage;
         GetComponent<MeshRenderer>().enabled = false;
         GetComponent<Collider>().enabled = false;
         yield return new WaitForSeconds(time);

        

     }
 }

 
}
