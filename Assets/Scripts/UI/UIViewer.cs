using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIViewer : MonoBehaviour
{
    public Action<float> OnTresholdChange;
    public Action<float> OnSpeedChange;
  
    [SerializeField] TextMeshProUGUI _speedText;
    [SerializeField] Slider _speedSlider; 
    [SerializeField] TextMeshProUGUI _tresholdText;
    [SerializeField] Slider _tresholdSlider;
    [SerializeField] TextMeshProUGUI _selectedUnitsText;

    public void Initialize()
    {
        InitializeSlider(_speedSlider, 5.0f, 5.0f, 8.0f, true);
        InitializeSlider(_tresholdSlider, 3.0f, 3.0f, 6.0f, true);
        _speedSlider.onValueChanged.AddListener(delegate { UpdateSpeedValue(); });
        _tresholdSlider.onValueChanged.AddListener(delegate { UpdateTresholdValue(); });
    }

    void InitializeSlider(Slider slider, float value, float minValue, float maxValue, bool interactable)
    {
        slider.value = value;
        slider.minValue = minValue;
        slider.maxValue = maxValue;
        slider.interactable = interactable;
        UpdateTresholdValue();
        UpdateSpeedValue();
    }
    private void Update()
    {
        _tresholdText.text = "Treshold ";
        _speedText.text = "Speed ";
    }

   public void UpdateSelectedUnitsText(int number)
    {
        _selectedUnitsText.text = "Selected Units " + number.ToString();
    }

    public void UpdateTresholdValue()
    {
        OnTresholdChange(_tresholdSlider.value);
    }

    public void UpdateSpeedValue()
    {
        OnSpeedChange(_speedSlider.value);
    }
}
