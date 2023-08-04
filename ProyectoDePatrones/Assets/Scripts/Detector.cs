using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Detector : MonoBehaviour
{
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
       
        if (collision.CompareTag("Enemigo"))
            Destroy(collision.gameObject);
    }
}
