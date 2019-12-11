using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public Collider _collider;
    public void Awake()
    {
      _collider = GetComponent<SphereCollider>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _spriteRenderer.enabled = false;
        _collider.enabled = false;
    }
}
