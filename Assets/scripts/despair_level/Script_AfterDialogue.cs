using UnityEngine;

public class DialogueReward : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private int rewardAmount = 1;

    private bool rewardGiven = false;

    public void OnDialogueFinished()
    {
        if (rewardGiven)
            return;

        playerInventory.AddItem(rewardAmount);

        rewardGiven = true;

        Debug.Log("Nagroda za dialog przyznana.");
    }
}