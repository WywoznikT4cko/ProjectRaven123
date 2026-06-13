using UnityEngine;

public class NPCQuest : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;

    public void GiveItemToNPC()
    {
        if (playerInventory.hasSpecialItem)
        {
            playerInventory.RemoveSpecialItem();

            Debug.Log("NPC otrzymał przedmiot!");

            // Tutaj możesz uruchomić nowy dialog
            // albo zakończyć zadanie.
        }
        else
        {
            Debug.Log("Nie masz wymaganego przedmiotu.");
        }
    }
}