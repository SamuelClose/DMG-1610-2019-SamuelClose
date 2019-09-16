using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{

    public ParticleSystem particles;

    private void OnTriggerEnter(Collider other)
    {
        particles.Emit(100);
    }
}
