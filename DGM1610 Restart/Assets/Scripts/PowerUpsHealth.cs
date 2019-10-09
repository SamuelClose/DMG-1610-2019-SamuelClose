using System.Collections;
using UnityEngine;
public class PowerUpsHealth : MonoBehaviour
{
    public int multiplier = 2;
    public int time = 4;
    public bool powerUp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider player)
    { 
        PlayerDisplay1 stats = player.GetComponent<PlayerDisplay1>();
        stats.playerHealth *= multiplier;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(time);
        stats.playerHealth /= multiplier;
    }
}


