using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PowerUpsHealth : MonoBehaviour
{
    public int multiplier = 2;
    public int time = 4;
    
    public bool powerUp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {

        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        PlayerDisplay stats = player.GetComponent<PlayerDisplay>();
        stats.playerHealth *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(time);

        stats.playerHealth /= multiplier;
        
    }

}


