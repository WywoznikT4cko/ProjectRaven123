using UnityEngine;

public class DialogueReward : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private RedScreenEffect redScreenEffect;

    private bool rewardGiven = false;

    public void GiveReward()
    {
        if (rewardGiven)
        {
            redScreenEffect.IncreaseRedness();
            return;
        }

        playerInventory.AddItem();

        redScreenEffect.IncreaseRedness();

        rewardGiven = true;

        Debug.Log("Przyznano nagrodę.");
    }
}