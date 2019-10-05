using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PowerUpsBombEffect : MonoBehaviour
{
    public int damage = 10;
    public float time = 25f;

 private void OnTriggerEnter(Collider other)
 {
     if (other.CompareTag("Player"))
     {
         StartCoroutine(Pickup (other));
     }

     IEnumerator Pickup (Collider player)
     {
         PlayerDisplay stats = player.GetComponent<PlayerDisplay>();
        
         GetComponent<MeshRenderer>().enabled = false;
         stats.playerHealth = -damage;
         GetComponent<Collider>().enabled = false;
         yield return new WaitForSeconds(time);

        

     }
 }

 
}
