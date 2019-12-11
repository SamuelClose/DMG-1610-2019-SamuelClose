using UnityEngine;
public class HealthPack : MonoBehaviour
{
    public int regen = 10;
    public PlayerDisplay stats;
    public void Awake()
    {
        stats = GetComponent<PlayerDisplay>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HealthBoost"))
        {
            stats.playerHealth += regen;
        }
    }
}
