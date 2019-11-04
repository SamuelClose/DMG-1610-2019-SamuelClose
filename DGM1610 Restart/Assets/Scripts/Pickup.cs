
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private PlayerDisplay1 _stat;
    private List<GameArtData> _inventory;
    public GameObject _object;
    private WeaponData _weaponData;

    IEnumerator ItemGrab(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("pick up item");
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("Got It!");
        }
        {
            Debug.Log("press E to pick up");
        }
        yield return true;
    }


    private void Start()
    {
        _stat = GetComponent<PlayerDisplay1>();
        _object = GetComponent<GameObject>();
        _inventory = _stat.inventory;
    }
    private void OnTriggerEnter(Collider other)
    {

        StartCoroutine(ItemGrab(other));

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            Debug.Log("Inventory open");
        }

        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log("Inspecting Inventory");
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            Debug.Log("Inventory Closed");
        }
    }
    
    
}
