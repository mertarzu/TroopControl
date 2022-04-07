using System;
using UnityEngine;

public class TargetInputController : MonoBehaviour
{
    public Action<Transform> OnTriggerInput;
   
    [SerializeField] LayerMask unitMask;
    [SerializeField] LayerMask unitMask2;

    Transform draggingTarget;
    Vector3 deltaPosition;
    bool isDragging;
    bool isGameActive;

    void Update()
    {
        if (isGameActive)
        {
            CheckTarget();
        }       
    }

    void CheckTarget()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, unitMask))
            {
                draggingTarget = hit.transform;
                deltaPosition = hit.point - draggingTarget.position;
                isDragging = true;
            }

        }
        else if (Input.GetMouseButton(0) && isDragging)
        {

            Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;

            if (Physics.Raycast(ray2, out hit2, Mathf.Infinity, unitMask2))
            {
                draggingTarget.position = new Vector3(hit2.point.x - deltaPosition.x, draggingTarget.position.y, hit2.point.z - deltaPosition.z);          
            }
        }
        else if (Input.GetMouseButtonUp(0) && isDragging)
        {
            draggingTarget = null;
            isDragging = false;
        }

        if (OnTriggerInput != null && isDragging)
        {
            OnTriggerInput(draggingTarget);
        }
    }

    public void Initialize()
    {
        isGameActive = true;
    }
}
