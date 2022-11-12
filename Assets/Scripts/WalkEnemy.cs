using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkEnemy : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;

    private Transform _playerTransform; 
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = gameObject.GetComponent<NavMeshAgent>();

        _playerTransform = GameObject.FindWithTag("Player").transform;

        _navMeshAgent.destination = _playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _navMeshAgent.destination = _playerTransform.position;
    }
}
