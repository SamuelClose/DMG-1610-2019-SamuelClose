using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
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
        GetComponent<Collider>().enabled = false;
        GetComponent<ParticleSystem>().Stop();
        yield return new ParticleSystemRenderer();
    }
}
