using UnityEngine;

public class QuestItem : MonoBehaviour
{
    [SerializeField] private ItemType itemType;
    [SerializeField] private PlayerInventory playerInventory;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerInventory.AddItem(itemType);
            Destroy(gameObject);
        }
    }









}

