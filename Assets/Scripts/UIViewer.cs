using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIViewer : MonoBehaviour
{
    public Action<float> OnTresholdChange;
    public Action<float> OnSpeedChange;

    [SerializeField] Slider tresholdSlider;
    [SerializeField] Slider speedSlider;
    [SerializeField] TextMeshProUGUI selectedUnitsText;
    [SerializeField] TextMeshProUGUI tresholdText;
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] Button playButton;
    public void Initialize()
    {
        tresholdSlider.minValue = 2;
        speedSlider.minValue = 2;
        tresholdSlider.maxValue = 8;
        speedSlider.maxValue = 10;
        tresholdSlider.value = 2f;
        speedSlider.value = 3.5f;
        tresholdSlider.interactable = true;
        speedSlider.interactable = true;
        playButton.gameObject.SetActive(false);

    }
    private void Update()
    {
        tresholdText.text = "Treshold " + System.Math.Round(tresholdSlider.value, 1);
        speedText.text = "Speed " + System.Math.Round(speedSlider.value, 1);
    }

   public void UpdateSelectedUnitsText(int num)
    {
        selectedUnitsText.text = num.ToString();
    }

    public void UpdateTresholdValue()
    {
        OnTresholdChange(tresholdSlider.value);
    }

    public void UpdateSpeedValue()
    {
        OnSpeedChange(speedSlider.value);
    }

}
