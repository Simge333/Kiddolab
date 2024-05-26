using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DusmanScript : MonoBehaviour
{
    private NavMeshAgent _navmeshAgent;
    [SerializeField] private Transform hedefTransform;
    void Start()
    {
        _navmeshAgent= GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        _navmeshAgent.SetDestination(hedefTransform.position);
    }
}
