using UnityEngine;

public class SelectionInputController : MonoBehaviour
{
    [SerializeField] SelectedUnits _selectedUnits;
    [SerializeField] LayerMask _unitMask;
    [SerializeField] UnitContainer _unitContainer;
    [SerializeField] SelectionIndicator _selectionIndicator;

    Vector3 _mousePosition1;
    Vector3 _mousePosition2;
    bool _isGameActive;

    public void Initialize()
    {
        _isGameActive = true;
    }

    void Update()
    {
        if (_isGameActive)
        {
            CheckSelectedUnit();
        }       
    }

    void CheckSelectedUnit()
    {

        if (Input.GetMouseButtonDown(1))
        {
            _mousePosition1 = Input.mousePosition;
           
            Ray ray = Camera.main.ScreenPointToRay(_mousePosition1);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, _unitMask))
            {

                if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
                {
                    _selectedUnits.RemoveSelectedUnits();
                }
                if (!_selectedUnits.isInSelectedUnitsList(hit.collider.gameObject.GetComponent<Unit>()))
                {
                    _selectedUnits.AddSelectedUnit(hit.collider.gameObject.GetComponent<Unit>());
                }

            }
            else if (Physics.Raycast(ray, out hit))
            {
                if (!hit.collider.CompareTag("Target"))
                {
                    if ( !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
                    {
                        _selectedUnits.RemoveSelectedUnits();                       
                    }                                  
                }
            }
            _selectionIndicator.DrawSelectionIndicator(_mousePosition1, _mousePosition1);
        }

        if (Input.GetMouseButton(1))
        {
            _mousePosition2 = Input.mousePosition;
            
            if (_mousePosition1 == _mousePosition2) return;

            if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
            {
                _selectedUnits.RemoveSelectedUnits();
            }

            for (int i = 0; i < _unitContainer.Count; i++)
            {
                    Bounds viewportBounds = GetViewportBounds(Camera.main, _mousePosition1, _mousePosition2);

                    if (viewportBounds.Contains(Camera.main.WorldToViewportPoint(_unitContainer.GetUnit(i).transform.position)))
                    {

                        if (!_selectedUnits.isInSelectedUnitsList(_unitContainer.GetUnit(i)))
                        {
                            _selectedUnits.AddSelectedUnit(_unitContainer.GetUnit(i));
                        }
                    }               
            }
            _selectionIndicator.UpdateSelectionIndicator(_mousePosition1, _mousePosition2);
        }

        if (Input.GetMouseButtonUp(1))
        {
            _selectionIndicator.ClearSelectionIndicator();
        }

    }
    Bounds GetViewportBounds(Camera camera, Vector3 screenPosition1, Vector3 screenPosition2)
    {
        Vector3 v1 = camera.ScreenToViewportPoint(screenPosition1);
        Vector3 v2 = camera.ScreenToViewportPoint(screenPosition2);
        Vector3 min = Vector3.Min(v1, v2);
        Vector3 max = Vector3.Max(v1, v2);
        min.z = camera.nearClipPlane;
        max.z = camera.farClipPlane;
        Bounds bounds = new Bounds();
        bounds.SetMinMax(min, max);
        return bounds;
    }

}
