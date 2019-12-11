using System;
using UnityEngine;
public class PowerUpsBombEffect : MonoBehaviour
{
    public PlayerDisplay info;
    public int damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bomb"))
        {
            info.playerHealth -= damage;
        }
    }
}
   

