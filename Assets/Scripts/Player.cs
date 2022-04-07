using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SelectedUnits selectedUnits;
    [SerializeField] TargetInputController targetInputController;
    [SerializeField] UIController uiController;

    void  onTargetSelected(Transform target)
    {
        foreach (Unit selectedUnit in selectedUnits.selectedUnits)
        {
            selectedUnit.PathFinder(target);
        }            
    }
  
    void OnSelectedNumChange(int value)
    {
        uiController.UpdateUnitNumber(value);
    }

    public void Initialize()
    {
        targetInputController.OnTriggerInput = onTargetSelected;   
        selectedUnits.OnSelectedNumChange = OnSelectedNumChange;
    }

}
