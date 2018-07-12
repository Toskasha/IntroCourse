using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIMonsterController : MonoBehaviour {

   private NavMeshAgent agent;

    public float MovementSpeed;
    public float AttackRadius;
    public float AttackCooldown;
    private float SetAttackCooldown;

    public GameObject Target;

    private Rigidbody RB;

    public Animator Anim;

    

    

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        RB = GetComponent<Rigidbody>();

        agent.speed = MovementSpeed;
        agent.acceleration = MovementSpeed * 2;
        agent.stoppingDistance = 1;
       
	}

   

    public void updateAnim()
    {
        Vector3 localVel = transform.InverseTransformDirection(agent.velocity);

        Anim.SetFloat("ForwardSpeed", localVel.z);
        
    }

    // Update is called once per frame
    void Update () {
        updateAnim();
        SetAttackCooldown -= Time.deltaTime;

        agent.SetDestination(Target.transform.position);

        float DistanceBetween = agent.remainingDistance;

        if (DistanceBetween <= AttackRadius)
        {
            agent.isStopped = true;

            if (SetAttackCooldown <= 0)
            {
                Anim.SetTrigger("Attack");

            }


        }
        else if(SetAttackCooldown <= 0)
        {
            agent.isStopped = false;
        }

	}
}
