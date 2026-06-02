using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int itemCount = 0;

    public void AddItem(int amount = 1)
    {
        itemCount += amount;

        Debug.Log("Otrzymano przedmiot. Aktualna ilość: " + itemCount);
    }
}