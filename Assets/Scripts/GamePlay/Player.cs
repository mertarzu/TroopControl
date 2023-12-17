using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SelectedUnits selectedUnits;
    [SerializeField] TargetInputController targetInputController;
    [SerializeField] UIController uiController;
    public void Initialize()
    {
        targetInputController.OnTriggerInput = onTargetSelected;
        selectedUnits.OnSelectedNumChange = OnSelectedNumChange;
    }

    void onTargetSelected(Transform target)
    {
        int count = selectedUnits.GetSelectedUnitsCount();
        for (int i=0; i < count; i++)
        {
            selectedUnits.selectedUnits[i].PathFinder(target.position, count, i);
        }            
    }
  
    void OnSelectedNumChange(int value)
    {
        uiController.UpdateUnitNumber(value);
    }

}
