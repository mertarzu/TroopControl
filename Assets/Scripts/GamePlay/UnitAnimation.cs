using System;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class UnitAnimation : MonoBehaviour
{
    [SerializeField] NavMeshAgent _navMeshAgent;
    [SerializeField] Animator _anim;
    Vector3 _target;
    public void SetLookAtPosition(Vector3 target)
    {
        _target = target;
       //_anim.SetLookAtPosition(target);
    }

    void Update()
    {    
        _anim.SetFloat("VelocityX", _navMeshAgent.velocity.x);
        _anim.SetFloat("VelocityZ", _navMeshAgent.velocity.z);
       // _anim.SetLookAtPosition(_target);
    }   
}
