using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
   public Dialogue dialogue;

   private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            dialogue.gameObject.SetActive(true);
            dialogue.StartDialogue();
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
