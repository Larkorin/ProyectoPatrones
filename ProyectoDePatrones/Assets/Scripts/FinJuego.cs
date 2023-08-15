using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{

    public GameObject PanelNPC;
    public GameObject PanelNPC2;


    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {
            ActivarPanel();
            ActivarTexto();

        }

    }


    void ActivarPanel()
    {
        PanelNPC.SetActive(true);
    }

    void ActivarTexto()
    {
        PanelNPC2.SetActive(true);
    }


}
