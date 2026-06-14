using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
   public Dialogue successDialogue;
   public Dialogue needItemDialogue; 
   [SerializeField] private ItemType requiredItem; 
   [SerializeField] private PlayerInventory playerInventory; 

 

   private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            if (playerInventory.HasItem(requiredItem))
            {
                successDialogue.gameObject.SetActive(true);
                successDialogue.StartDialogue();
            }
            else
            {
                needItemDialogue.gameObject.SetActive(true);
                needItemDialogue.StartDialogue();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
