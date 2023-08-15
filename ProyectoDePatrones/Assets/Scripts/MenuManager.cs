using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Lorem;
    public GameObject Menu;
    public void BotonIncio()
    {
        
        Lorem.SetActive(true);
        Menu.SetActive(false);
        
    }

    
    public void BotonSalir()
    {
       Application.Quit();
    }



    public void BotonRegresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void BotonSaltar()
    {
        SceneManager.LoadScene("Maps");
    }
}
