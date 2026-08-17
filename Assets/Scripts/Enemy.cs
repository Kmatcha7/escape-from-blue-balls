using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    //public GameObject Enemy;
    //public GameObject Enemy1;
    //public GameObject Enemy2;
    //public GameObject Enemy3;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    
        
            
        
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        if (Input.GetKey(KeyCode.Space))
        {         
            agent.speed = 10;
            Debug.Log("speed up");
        }
    }
}
