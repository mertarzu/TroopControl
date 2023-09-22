using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.AI;

public class Unit : MonoBehaviour
{
    [SerializeField] PathFinder _pathFinder;
    [SerializeField] GameObject _selectionBox;
    [SerializeField] UnitAnimation _unitAnimation;
    public void PathFinder(Vector3 targetPosition, int totalAgents, int agentIndex)
    {     
       
        _pathFinder.NavigateUnit(targetPosition, totalAgents, agentIndex);
        
    }

    public void SetSpeed(float speed)
    {
        _pathFinder.SetSpeed(speed);   
    }

    public void SetTreshold(float treshold)
    {
        _pathFinder.SetTreshold(treshold);
    }

    public void ActivateSelectionBox()
    {
        _selectionBox.SetActive(true);
    }

    public void DeactivateSelectionBox()
    {
        _selectionBox.SetActive(false);
    }

    public void SetLookAtPosition(Vector3 target)
    {
        _unitAnimation.SetLookAtPosition(target);
    }
}
