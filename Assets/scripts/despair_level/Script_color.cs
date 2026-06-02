using UnityEngine;
using UnityEngine.UI;

public class RedScreenEffect : MonoBehaviour
{
    [SerializeField] private Image redOverlay;
    [SerializeField] private int maxItems = 3;

    private int collectedItems = 0;

    public void CollectItem()
    {
        collectedItems++;

        float alpha = (float)collectedItems / maxItems;
        alpha = Mathf.Clamp01(alpha);

        Color color = redOverlay.color;
        color.a = alpha;
        redOverlay.color = color;
    }
}