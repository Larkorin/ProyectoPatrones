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
    public bool bandera { get; set; }




    public Detector()
    {
        //this.herido = herido;
    }



    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {

        if (collision.CompareTag("Rana")|| (collision.CompareTag("Aguila")||(collision.CompareTag("Extraterrestre")|| (collision.CompareTag("Dog")))))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Enemigo"))
        {
           herido = true;

           
        }




        if (collision.CompareTag("Player"))
        {

            bandera = true;
            Debug.Log("bandera" + bandera);

        }



    }
}