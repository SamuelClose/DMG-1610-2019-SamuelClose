
using System.Collections;
using System.IO;
using UnityEngine;
public class PowerUpsBombEffect : MonoBehaviour
{
    public int damage = 10;
    public float time = 25f;

 private void OnTriggerEnter(Collider other)
 {
     if (other.CompareTag("Player"))
     {
         StartCoroutine(Pickup (other));
     }
     IEnumerator Pickup (Collider player)
     {
         PlayerDisplay1 stats = player.GetComponent<PlayerDisplay1>();
         GetComponent<MeshRenderer>().enabled = false;
         stats.playerHealth = -damage;
         GetComponent<Collider>().enabled = false;
         yield return new WaitForChangedResult();
     }
 }

 
}
