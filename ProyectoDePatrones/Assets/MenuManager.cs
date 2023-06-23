using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonIncio()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void BotonSalir()
    {
        Debug.Log("Salimos de la aplicación");
            Application.Quit();
    }
}
