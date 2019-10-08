using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{ 
    public GameObject player; 
    void Start()
    {
       
        Instantiate(player, new Vector3(11.53f, 2.81f, 3.667f), Quaternion.identity);
    }
}
