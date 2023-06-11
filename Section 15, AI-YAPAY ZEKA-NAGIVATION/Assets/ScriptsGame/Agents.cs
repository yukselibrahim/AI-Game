using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agents : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] GameObject hedef;
    
    [SerializeField] string ajanTuru;
    private int carpmasayisi;
    private float darbeGucu;
    [SerializeField] GameKontrol gameKontrol;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(hedef.transform.position);

        switch (ajanTuru)
        {
            case "Yesil":
                carpmasayisi = 3;
                darbeGucu = 20f;
                break;

            case "Mavi":
                carpmasayisi = 2;
                darbeGucu = 10f;
                break;

            case "Gri":
                carpmasayisi = 1;
                darbeGucu = 8f;
                break;
        }
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            if (carpmasayisi != 0)
            {
                carpmasayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("AnaHedef"))
        {
            gameKontrol.GetComponent<GameKontrol>().CanDusur(darbeGucu);
            Destroy(gameObject);
        }
    }
}
