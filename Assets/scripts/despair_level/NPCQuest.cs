using UnityEngine;

public class NPCQuest : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;

    public void GiveItemToNPC()
    {
        if (playerInventory.hasSpecialItem)
        {
            playerInventory.GiveSpecialItemToNPC();

            Debug.Log("NPC otrzymał przedmiot!");

        }
        else
        {
            Debug.Log("Nie masz wymaganego przedmiotu.");
        }
    }
}