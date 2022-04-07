using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] PathFinder pathFinder;
    [SerializeField] GameObject selectionBox;
      
    public void PathFinder(Transform target)
    {       
        pathFinder.NavigateUnit(target.position);
    }

    public void SetSpeed(float speed)
    {
        pathFinder.SetSpeed(speed);   
    }

    public void SetTreshold(float treshold)
    {
        pathFinder.SetTreshold(treshold);
    }

    public void ActivateSelectionBox()
    {
        selectionBox.SetActive(true);
    }

    public void DeactivateSelectionBox()
    {
        selectionBox.SetActive(false);
    }
}
