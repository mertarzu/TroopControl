using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] UIViewer _uiViewer;
    [SerializeField] UnitContainer _unitContainer;

    public void Initialize()
    {
        _uiViewer.OnSpeedChange += onSpeedChange;
        _uiViewer.OnTresholdChange += onTresholdChange;   
        _uiViewer.Initialize();
    }
    public void UpdateUnitNumber(int num)
    {
        _uiViewer.UpdateSelectedUnitsText(num);
    }

    void onTresholdChange(float value)
    {
        _unitContainer.SetTresholdOfUnit(value);
    }

    void onSpeedChange(float value)
    {
        _unitContainer.SetSpeedOfUnit(value);        
    }
}
