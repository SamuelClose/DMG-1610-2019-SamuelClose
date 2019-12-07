using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotion : MonoBehaviour
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
            PlayerDisplay1 stats = player.GetComponent<PlayerDisplay1>();
            stats.playerMagic += regen;

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            yield return (stats.playerMagic);
        }
    }

    void Update()
    {
        
    }
}

