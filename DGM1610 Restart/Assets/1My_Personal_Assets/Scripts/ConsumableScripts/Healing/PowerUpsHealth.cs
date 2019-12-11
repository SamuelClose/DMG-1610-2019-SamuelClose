using System.Collections;
using UnityEngine;
public class PowerUpsHealth : MonoBehaviour
{
    public int multiplier = 2;
    public int time = 4;
    public bool powerUp;
    private Collider _collider;
    private MeshRenderer _meshRenderer;
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }
    IEnumerator Pickup(Collider player)
    {
        //PlayerDisplay.playerHealth *= multiplier;
        _meshRenderer.enabled = false;
        _collider.enabled = false;
        yield return new WaitForSeconds(time);
        //PlayerDisplay.playerHealth /= multiplier;
    }
}


