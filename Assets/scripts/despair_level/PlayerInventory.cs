using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int itemCount = 0;

    public void AddItem()
    {
        itemCount++;

        Debug.Log("Otrzymano przedmiot. Łącznie: " + itemCount);
    }

    public bool HasItem()
    {
        return itemCount > 0;
    }

    public void RemoveItem()
    {
        if (itemCount > 0)
        {
            itemCount--;
        }
    }

// Specjalny przedmiot, który gracz może otrzymać

    public bool hasSpecialItem = false;

    public void GiveSpecialItem()
    {
        hasSpecialItem = true;
        Debug.Log("Gracz otrzymał specjalny przedmiot.");
    }

    public bool GiveSpecialItemToNPC()
    {
        if (!hasSpecialItem)
            return false;

        hasSpecialItem = false;

        Debug.Log("Gracz oddał specjalny przedmiot.");
        return true;
    }
}