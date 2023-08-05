using Assets.Scripts.Decorator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool herido { get; set; }

    public Detector(bool herido)
    {
        this.herido = herido;
    }

    public Detector()
    {
        //this.herido = herido;
    }



    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        
        if (collision.CompareTag("Rana"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Enemigo"))
        {
            Debug.Log("Verifico si el boss es herido" + herido);
            herido = true;
            Debug.Log("Verifico si cambio el status" + herido);

        }

     
    }


   
}
