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
}