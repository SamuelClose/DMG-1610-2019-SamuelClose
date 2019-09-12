using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PowerUpsHealth : MonoBehaviour
{
    public float multiplier = 2.6f;
    public float time = 4f;
    
    public bool powerUp;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {

        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        PlayerHealth stats = player.GetComponent<PlayerHealth>();
        stats.health *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(time);

        stats.health /= multiplier;
        
    }

}


