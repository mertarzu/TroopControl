using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float cameraSpeed;
    public void MoveCamera(Vector3 pos)
    {
        transform.Translate(pos * cameraSpeed * Time.deltaTime);
    }
}
