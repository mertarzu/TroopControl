using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour
{
    [SerializeField] NavMeshAgent _navMeshAgent;
    Vector3 _targetPosition;
    float _circleRadius;
    float _speed = 5;
   
    public void NavigateUnit(Vector3 targetPosition, int totalAgents, int agentIndex)
    {
        _targetPosition = targetPosition;
        float angleIncrement = 360f / totalAgents;
        float angle = angleIncrement * agentIndex;
        Vector3 offset = Quaternion.Euler(0, angle, 0) * (Vector3.forward * _circleRadius);
        Vector3 agentPosition = targetPosition + offset;
        _navMeshAgent.SetDestination(agentPosition);
    }

    public void SetSpeed(float speed)
    {
        _navMeshAgent.speed = speed;        
    }

    public void SetTreshold(float treshold)
    {
        _circleRadius = treshold;       
    }

    private void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(_targetPosition - _navMeshAgent.transform.position);
        _navMeshAgent.transform.rotation = Quaternion.Slerp(_navMeshAgent.transform.rotation, targetRotation, _speed * Time.deltaTime);
    }
}
