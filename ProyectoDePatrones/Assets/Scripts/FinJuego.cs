using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FinJuego : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    private bool check;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {      
            GameManager.Instance.GameOver();
            check = true;
     
        }

    }

    void Update()
    {
        if (check == true)
        {
            Invoke("ActivarPanel", 0f);
        }
        
    }

    // Update is called once per frame
    void ActivarPanel()
    {
        Panel.SetActive(true);
    }

}
