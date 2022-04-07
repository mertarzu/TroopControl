using System.Collections.Generic;
using UnityEngine;

public class UnitContainer : MonoBehaviour
{
    [SerializeField] List<Unit> allUnits = new List<Unit>();
    public int Count => allUnits.Count;
  
    public void SetTresholdOfUnit(float value)
    {
        foreach (Unit unit in allUnits)
        {
            unit.SetTreshold(value);     
        }
    }
    public void SetSpeedOfUnit(float value)
    {
        foreach (Unit unit in allUnits)
        {
            unit.SetSpeed(value);        
        }
    }

    public Unit GetUnit(int i)
    {
        return allUnits[i];
    }

}
