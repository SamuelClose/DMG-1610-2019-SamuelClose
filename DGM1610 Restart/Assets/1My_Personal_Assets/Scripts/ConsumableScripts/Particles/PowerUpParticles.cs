using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PowerUpParticles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }


    private IEnumerator Pickup(Collider player)
    {
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<ParticleSystem>().Stop();
        yield return new ParticleSystemRenderer();
    }
}
