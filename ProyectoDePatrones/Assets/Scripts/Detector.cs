using Assets.Scripts.Decorator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool herido;
    public bool bandera { get; set; }


    public void Start()
    {
       herido = false;
       
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        

        if (collision.CompareTag("Rana")|| (collision.CompareTag("Aguila")||(collision.CompareTag("Extraterrestre")|| (collision.CompareTag("Dog")))))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemigo")
        {
          
            herido = true;

        }

        if (collision.CompareTag("Player"))
        {
            bandera = true;
        }

    }

}