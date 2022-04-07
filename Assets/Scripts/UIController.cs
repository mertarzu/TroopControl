using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] UIViewer uiViewer;
    [SerializeField] UnitContainer unitContainer;

    public void UpdateUnitNumber(int num)
    {
        uiViewer.UpdateSelectedUnitsText(num);
    }
 
    public void Initialize()
    {
        uiViewer.OnSpeedChange = onSpeedChange;
        uiViewer.OnTresholdChange = onTresholdChange;   
        uiViewer.Initialize();
    }

    void onTresholdChange(float value)
    {
        unitContainer.SetTresholdOfUnit(value);
    }

    void onSpeedChange(float value)
    {
        unitContainer.SetSpeedOfUnit(value);        
    }
}
