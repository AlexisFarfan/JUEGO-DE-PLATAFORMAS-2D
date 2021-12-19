using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;
    [SerializeField] GameObject Trampa;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(true)
        {
            Disparar();
        }
        //Disparar();
    }



    private void Disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
