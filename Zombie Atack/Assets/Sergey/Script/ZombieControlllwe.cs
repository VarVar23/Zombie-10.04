using UnityEngine;
using UnityEngine.AI;

public class ZombieControlllwe : MonoBehaviour
{
    private NavMeshAgent _agent;
    private void Death()
    {
        FindObjectOfType<SpawnZombies>().CountZombies--;
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
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<MoveController>().Death(); 
        }
    }

    private void Update()
    {
        var player = FindObjectOfType<MoveController>();
        _agent.SetDestination(player.transform.position);
    }
}
