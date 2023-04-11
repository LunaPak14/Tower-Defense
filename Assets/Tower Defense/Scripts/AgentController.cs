using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform destination;

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination.position);
        Transform enemy = GetComponent<Transform>();
        if ((int)enemy.transform.position.x == (int)destination.position.x && (int)enemy.transform.position.z == (int)destination.position.z)
        {
            EndPath();
            return;
        }
    }
    
    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
