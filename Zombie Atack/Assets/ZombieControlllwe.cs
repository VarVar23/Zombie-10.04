using System;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class ZombieControlllwe : MonoBehaviour
{
    private NavMeshAgent _agent;
    private void Death()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Death();
        }
    }

    private void Update()
    {
        var player = FindObjectOfType<Player>();
        _agent.SetDestination(player.transform.position);
    }
}
