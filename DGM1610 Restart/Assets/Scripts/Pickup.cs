using UnityEngine;
public class Pickup : MonoBehaviour
{
    public CollectionData inventory;
    private void Start()
    {
        inventory = GetComponent<CollectionData>();
    } 
    private void OnTriggerExit(Collider other)
    {
        inventory.collectionList.Add(null);
    }
}
       
