using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animation anim;
    public AudioSource au;
    bool walkControl, viewControl, idleAnimControl;

    [SerializeField] GameObject player;
    [SerializeField] float viewDegree, viewHorizontalDistance, viewVerticalDistance, walkSpeed, runSpeed;

    [SerializeField] float walkRange;
    [SerializeField] GameObject spiderArea;
    Vector3 walkPosition;

    private void Start()
    {
        StartCoroutine(WalkCoroutine());
    }

    void Update()
    {

        Vector3 dir = player.transform.position - transform.position;
        float vectorY = player.transform.position.y - transform.position.y;
        float vectorX = player.transform.position.x - transform.position.x;
        float vectorZ = player.transform.position.z - transform.position.z;


        if ((Mathf.Abs(Vector3.Angle(transform.forward, dir)) < viewDegree) && vectorY < viewVerticalDistance && vectorX < viewHorizontalDistance && vectorZ < viewHorizontalDistance)
        {
            viewControl = true;
            anim.Play("run");
            au.Play(0);
            agent.speed = runSpeed;
            agent.SetDestination(player.transform.position);
        } else
        {
            viewControl = false;
        }

        if (walkControl && !viewControl)
        {
            StartCoroutine(WalkCoroutine());
        }

        if (agent.remainingDistance > 0.02f)
            idleAnimControl = false;

        if (!idleAnimControl)
        {
            if(agent.remainingDistance < 0.02f)
            idleAnimation();
        }

    }

    void randomPosition()
    {

        float randomX = Random.Range(-walkRange, walkRange);
        float randomZ = Random.Range(-walkRange, walkRange);

        walkPosition = new Vector3(randomX + spiderArea.transform.position.x,transform.position.y ,randomZ + transform.position.z);
    }

    void idleAnimation()
    {
        anim.Play("idle");
        idleAnimControl = true;
    }

    IEnumerator WalkCoroutine()
    {
        walkControl = false;

        randomPosition();

        agent.speed = walkSpeed;

        anim.Play("walk");

        agent.SetDestination(walkPosition);

        int randomSecond = Random.Range(5, 20);

        yield return new WaitForSeconds(randomSecond);
        walkControl = true;
    }

}
