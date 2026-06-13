using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
   public Dialogue dialogue;
   public Dialogue successDialogue;
   public Dialogue needItemDialogue; 
   public PlayerInventory playerInventory; 

   private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            if (playerInventory.HasItem())
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
