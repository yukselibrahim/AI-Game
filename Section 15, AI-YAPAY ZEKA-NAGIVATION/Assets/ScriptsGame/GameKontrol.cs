using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameKontrol : MonoBehaviour
{
    private float saðlik;
    [SerializeField] Image Healthbar;
    [SerializeField] GameObject[] noktalar;

    void Start()
    {
        saðlik = 100;
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
