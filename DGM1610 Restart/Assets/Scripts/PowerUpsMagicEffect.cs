using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PowerUpsMagicEffect : MonoBehaviour
{
    [FormerlySerializedAs("multiplier")] public float multiplier = 2f;
    public float time = 6f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(routine: Pickup(other));
        }
        
    }

    private IEnumerator Pickup(Collider player)
    {
        PlayerMagic stats = player.GetComponent<PlayerMagic>();
        stats.mana *= multiplier;
        
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(time);

        stats.mana /= multiplier;

    }

    

}
