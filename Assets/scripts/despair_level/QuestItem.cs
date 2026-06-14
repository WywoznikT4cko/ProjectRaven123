using UnityEngine;

public class QuestItem : MonoBehaviour
{
    [SerializeField] private ItemType itemType;
    [SerializeField] private PlayerInventory playerInventory;

    private bool playerInRange  = false; 

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.B))
        {
            playerInventory.AddItem(itemType);
            Destroy(gameObject);
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
     private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}