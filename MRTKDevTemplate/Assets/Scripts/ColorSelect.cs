using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Renderer objectRenderer;
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    private void Start()
    {
        Color currentColor = objectRenderer.material.color;
        redSlider.value = currentColor.r;
        greenSlider.value = currentColor.g;
        blueSlider.value = currentColor.b;

        redSlider.onValueChanged.AddListener(UpdateColor);
        greenSlider.onValueChanged.AddListener(UpdateColor);
        blueSlider.onValueChanged.AddListener(UpdateColor);
    }

    public void UpdateColor(float value)
    {
        Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
        objectRenderer.material.color = newColor;
    }
}
