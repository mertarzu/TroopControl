using System;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class UnitAnimation : MonoBehaviour
{
    [SerializeField] NavMeshAgent _navMeshAgent;
    [SerializeField] Animator _anim;
   
    void Update()
    {    
        _anim.SetFloat("VelocityX", _navMeshAgent.velocity.x);
        _anim.SetFloat("VelocityZ", _navMeshAgent.velocity.z);
    }   
}
