using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
 
 public Transform player;
 private NavMeshAgent navMeshAgent;

 
 void Start()
    {
 
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

 
 void Update()
    {
 
        if (player != null)
                {    
                    navMeshAgent.SetDestination(player.position);
                }
            }

            
                void OnTriggerEnter (Collider other)
            
            {
             if (other.gameObject. CompareTag ("Teleport"))
                {
                    other.gameObject.SetActive(false);
                    transform.position = new Vector3 (0f,0.5f,0f);
                }
            }

}

