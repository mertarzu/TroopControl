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
        InitializeSlider(_speedSlider, 5.0f, 5.0f, 10.0f, true);
        InitializeSlider(_tresholdSlider, 2.0f, 2.0f, 6.0f, true);
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
        _tresholdText.text = "Treshold ";// + System.Math.Round(_tresholdSlider.value, 1);
        _speedText.text = "Speed ";// + System.Math.Round(_speedSlider.value, 1);
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
