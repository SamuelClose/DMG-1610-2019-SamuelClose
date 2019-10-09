using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HealthPack : MonoBehaviour
{

    public float regen = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }


        IEnumerator Pickup(Collider player)
        {
            
            
            PlayerDisplay stats = player.GetComponent<PlayerDisplay>();
            stats.playerHealth += regen;
            GetComponent<MeshRenderer>().enabled = false;
            
            GetComponent<Collider>().enabled = false;
            yield return (stats.playerHealth < stats.playerMaxHealth);
        }
    }

    void Update()
    {
        
    }
}
