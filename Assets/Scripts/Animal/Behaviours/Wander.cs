using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander : IBehaviour
{
    Animal animal;
    GameObject unit;
    NavMeshAgent agent;
    public Wander(GameObject go, Animator anim, NavMeshAgent nva)
    {
        unit = go;
        animator = anim;
        agent = nva;
    }
    public IEnumerator Do()
    {
        while (true)
        {
            Debug.Log("Start Do!");
            agent.SetDestination(unit.transform.position + new Vector3(Random.Range(-3f, 3f), 0, Random.Range(-3f, 3f)));
            yield return new WaitForSeconds(7);
        }
    }
}
