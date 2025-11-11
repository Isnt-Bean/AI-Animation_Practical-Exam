using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;

    public DetectPlayer dp;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        //make this activate when in sphere
        if (dp.searchForPlayer)
        {
            agent.destination = Target.transform.position;
        }
        else
        {
            //walk the way points
        }

    }

    private void OnTriggerEnter(Collider other)      //if it hits the target
    {
        if (other.name == "Target")
        {
            agent.speed = 3.5f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Target")
        {           
            //edit here
            
        }
    }

}
