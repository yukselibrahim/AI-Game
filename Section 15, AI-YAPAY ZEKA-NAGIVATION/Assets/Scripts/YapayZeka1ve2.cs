using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YapayZeka1ve2 : MonoBehaviour
{
    //NOT: Tak�ld���n yerde izle



    NavMeshAgent agent;
    public GameObject target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        agent.SetDestination(target.transform.position);   //NavMeshAgent lara hedef vermemiz i�in SetDestination komutunu kullan�r�z. Sonras�nda bunun i�in gitmesini istedi�imiz hedefim position nunu veririz.
    }
}
