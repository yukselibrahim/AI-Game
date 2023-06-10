using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YapayZeka5 : MonoBehaviour
{
    NavMeshAgent agent;
    /*[SerializeField] GameObject hedef1;
    [SerializeField] GameObject hedef2; */ //bunu bir dizi mant��� ile daha kolay bir �ekilde yapabiliriz a�a��da oldu�u gibi
    
    [SerializeField] GameObject[] hedefler; //hedeflere indis numaralar� �zerinde eri�ece�iz. 
    //private string mevcutDurum;
    private int mevcutDurum;

    
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //mevcutDurum = "hedef1";
        //agent.SetDestination(hedef1.transform.position);

        mevcutDurum = 0;
        agent.SetDestination(hedefler[0].transform.position);
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (mevcutDurum==0/*mevcutDurum=="hedef1"*/)
        {
            //mevcutDurum = "hedef2";
            //agent.SetDestination(hedef2.transform.position);

            mevcutDurum = 1;
            agent.SetDestination(hedefler[mevcutDurum].transform.position);
        }
        else
        {
            //mevcutDurum = "hedef1";
            //agent.SetDestination(hedef1.transform.position);

            mevcutDurum = 0;
            agent.SetDestination(hedefler[mevcutDurum].transform.position);
        }
    }
}
