using System.Collections.Generic;
using UnityEngine;

public class UnitContainer : MonoBehaviour
{
    [SerializeField] List<Unit> _allUnits = new List<Unit>();
    public int Count => _allUnits.Count;
  
    public void SetTresholdOfUnit(float value)
    {
        foreach (Unit unit in _allUnits)
        {
            unit.SetTreshold(value);     
        }
    }
    public void SetSpeedOfUnit(float value)
    {
        foreach (Unit unit in _allUnits)
        {
            unit.SetSpeed(value);        
        }
    }

    public Unit GetUnit(int i)
    {
        return _allUnits[i];
    }

}
