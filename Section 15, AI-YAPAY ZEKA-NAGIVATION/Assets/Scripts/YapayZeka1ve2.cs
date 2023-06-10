using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YapayZeka1ve2 : MonoBehaviour
{
    //NOT: Takýldýðýn yerde izle



    NavMeshAgent agent;
    public GameObject target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        agent.SetDestination(target.transform.position);   //NavMeshAgent lara hedef vermemiz için SetDestination komutunu kullanýrýz. Sonrasýnda bunun için gitmesini istediðimiz hedefim position nunu veririz.
    }
}
