using Assets.Scripts.Decorator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool herido;


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        
        if (collision.CompareTag("Rana")|| collision.CompareTag("Dog")|| collision.CompareTag("Aguila")|| collision.CompareTag("Extraterrestre"))
        {
            Destroy(collision.gameObject);
        }

    }

}
