using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Ciao : MonoBehaviour
{
    
    
    
    public NavMeshAgent agent;

    //private Vector3 posizione;





    void Start()
    {
        
    }


    void Update()
    {
       //posizione= GameObject.FindGameObjectWithTag("Player").transform.position;

        agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
    }
}
