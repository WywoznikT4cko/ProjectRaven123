using UnityEngine;

public class DialogueReward : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private RedScreenEffect redScreenEffect;

    private bool rewardGiven = false;

    public void GiveReward()
    {
        
        if (rewardGiven)
            return;

        if (!playerInventory.HasItem())
            return;

        playerInventory.RemoveItem();      //gracz oddaje przedmiot NPC
        playerInventory.AddItem();        // gracz otrzymuje nagrodę

        redScreenEffect.IncreaseRedness();

        rewardGiven = true; 

        Debug.Log("Zadanie wykonane. Przyznano nagrodę");
    
           
  
       
    }
}