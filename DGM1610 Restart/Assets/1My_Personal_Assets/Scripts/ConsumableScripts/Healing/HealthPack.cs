using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HealthPack : MonoBehaviour
{

    public float regen = 10f;
    public PlayerDisplay stats;
    public void Awake()
    {
        stats = GetComponent<PlayerDisplay>();
    }
    private void OnTriggerEnter(Collider other)
    {
        stats.playerHealth += regen;
    }
}
