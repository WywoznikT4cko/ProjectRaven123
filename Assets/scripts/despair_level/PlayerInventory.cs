using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public ItemType currentItem = ItemType.None;

    public void AddItem(ItemType item)
    {
        currentItem = item;

        Debug.Log("Podniesiono" + item);
    }

    public bool HasItem(ItemType item)
    {
        return currentItem == item;
    }

    public void RemoveItem()
    {
        currentItem = ItemType.None; 
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