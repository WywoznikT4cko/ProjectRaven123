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
}