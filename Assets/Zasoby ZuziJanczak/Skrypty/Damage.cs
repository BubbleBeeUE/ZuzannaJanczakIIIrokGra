using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Damage : MonoBehaviour
{
    public playerHealth pHealth;
    public float damage;
    public float damageRadius = 1f;

    private bool isDamaged;


    Transform target;
    NavMeshAgent agent;


    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
       
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= damageRadius && !isDamaged)
        {
            Debug.Log("Obszar obra¿eñ");

            pHealth.health -= damage;

        }
    }

    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, damageRadius);
    }
}

