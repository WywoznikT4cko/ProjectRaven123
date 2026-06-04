using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int itemCount = 0;

    public void AddItem()
    {
        itemCount++;

        Debug.Log("Otrzymano przedmiot. Łącznie: " + itemCount);
    }
}