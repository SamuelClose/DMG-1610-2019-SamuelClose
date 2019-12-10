using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private SphereCollider _sphereCollider;
    public void Awake()
    {
        _sphereCollider = GetComponent<SphereCollider>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _spriteRenderer.enabled = false;
        _sphereCollider.enabled = false;
    }
}
