using UnityEngine;
using UnityEngine.AI;

public class бежатьнаплощадь : MonoBehaviour
{

    public Transform Plochad;

    public NavMeshAgent Agent;

    public Animator Animator;



    void Start()
    {
        Animator.SetTrigger("Stop");
    }

    void Update()
    {


        Agent.SetDestination( Plochad.position);

        float Dist = Vector3.Distance(Plochad.position,Agent.transform.position);
    }
}
