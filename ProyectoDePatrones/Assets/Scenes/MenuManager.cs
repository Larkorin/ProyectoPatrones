using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void BotonIncio()
    {
        SceneManager.LoadScene("Maps");
    }

    
    public void BotonSalir()
    {
        Debug.Log("Salimos de la aplicación");
            Application.Quit();
    }


    public void BotonRegresar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
