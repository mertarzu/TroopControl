using System.Collections;
using System.Net;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class PathFinder : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    float _circleRadius;

    public void NavigateUnit(Vector3 targetPosition, int totalAgents, int agentIndex)
    {      
        float angleIncrement = 360f / totalAgents;
        float angle = angleIncrement * agentIndex;
        Vector3 offset = Quaternion.Euler(0, angle, 0) * (Vector3.forward * _circleRadius);
        Vector3 agentPosition = targetPosition + offset;

        navMeshAgent.SetDestination(agentPosition);
        StartCoroutine(WaitForAgentToStopAndLookAt(targetPosition, agentPosition));
    }
    private IEnumerator WaitForAgentToStopAndLookAt(Vector3 lookAtPosition, Vector3 targetPosition)
    {
        while (Vector3.Distance(navMeshAgent.transform.position, targetPosition) > 1f)
        {
            yield return null; 
        }
        navMeshAgent.transform.LookAt(lookAtPosition);
    }
    public void SetLookAtPosition(Vector3 lookAtPosition)
    {
        navMeshAgent.transform.LookAt(lookAtPosition);
    }
    public void SetSpeed(float speed)
    {
        navMeshAgent.speed = speed;        
    }

    public void SetTreshold(float treshold)
    {
        _circleRadius = treshold;       
    }

}
