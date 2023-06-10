using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlusacakObje : MonoBehaviour
{

    private int carpmasayisi = 3;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Agent"))
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
        
    }
   





}
