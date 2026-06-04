using UnityEngine;
using UnityEngine.UI;

public class RedScreenEffect : MonoBehaviour
{
    [SerializeField] private Image redOverlay;

    [SerializeField] private float alphaIncrease = 0.1f;

    private float currentAlpha = 0f;

    public void IncreaseRedness()
    {

        currentAlpha += alphaIncrease;
        currentAlpha = Mathf.Clamp01(currentAlpha);

        Color color = redOverlay.color;
        color.a = currentAlpha;
        redOverlay.color = color;
    }
}