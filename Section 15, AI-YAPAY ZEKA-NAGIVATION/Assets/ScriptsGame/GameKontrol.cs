using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameKontrol : MonoBehaviour
{
    private float sa�lik;
    [SerializeField] Image Healthbar;
    [SerializeField] GameObject[] noktalar;

    void Start()
    {
        sa�lik = 100;
    }

    
    void Update()
    {
        
    }

    public void NoktaButonlari(int indisdeger)
    {
        noktalar[indisdeger].GetComponent<MeshRenderer>().enabled = true;
        Debug.Log(indisdeger);
    }
}
