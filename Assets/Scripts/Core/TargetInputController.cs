using System;
using UnityEngine;

public class TargetInputController : MonoBehaviour
{
    public Action<Transform> OnTriggerInput;
   
    [SerializeField] LayerMask _unitMask;
    [SerializeField] LayerMask _unitMask2;

    Transform _target;
    Vector3 _deltaPosition;
    float clickStartTime;
    bool _isGameActive;
    bool isDragging;
    public void Initialize()
    {
        _isGameActive = true;
    }
    void Update()
    {
        if (_isGameActive)
        {
            CheckTarget();
        }       
    }

    void CheckTarget()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartTime = Time.time;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _unitMask))
            {
                _target = hit.transform;
                _deltaPosition = hit.point - _target.position;
                isDragging = true;
            }
            else
            {
                _target = null;
            }
        }
        else if (Input.GetMouseButton(0) && isDragging)
        {
            float clickDuration = Time.time - clickStartTime;
           
            if (clickDuration > .2f)
            {                        
                Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit2;

                if (Physics.Raycast(ray2, out hit2, Mathf.Infinity, _unitMask2))
                {
                    _target.position = new Vector3(hit2.point.x - _deltaPosition.x, _target.position.y, hit2.point.z - _deltaPosition.z);
                }
            }
           
        }
        else if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            _target = null;
        }
        if (OnTriggerInput != null && _target != null)
        {
            OnTriggerInput(_target);
        }
    }
 
}
