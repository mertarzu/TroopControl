using System;
using System.Collections.Generic;
using UnityEngine;

public class SelectedUnits : MonoBehaviour
{
    public Action<int> OnSelectedNumChange;
    public List<Unit> selectedUnits = new List<Unit>();
    public void AddSelectedUnit(Unit unit)
    {
        selectedUnits.Add(unit);
        unit.ActivateSelectionBox();
        OnSelectedNumChange(selectedUnits.Count);
    }

    public void RemoveSelectedUnits()
    {
        foreach (Unit unit in selectedUnits)
        {
            unit.DeactivateSelectionBox();
        }
        
        selectedUnits.Clear();
        OnSelectedNumChange(selectedUnits.Count);
    }

    public int GetSelectedUnitsCount()
    {
        return selectedUnits.Count;
    }
    public bool isInSelectedUnitsList(Unit unit)
    {
        if (selectedUnits.Contains(unit)) return true;
        else return false;
    }

}
