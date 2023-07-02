using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    public bool isGameOver;
    
    //Patron SINGLETON:
    //Va manejar el mensaje de texto de game over, reiniciar el nivel, actualizar puntajes y todo
    //aquello relacionado con el seguimiento del juego en una sola instancia

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    // Para llamar a la instancia o cualquier preconfiguracion del start se realiza en la funcion de Awake
    void Awake()
    {
        // Si la instancia(gameMager) es igual null entonces genere una de lo contrario que la destruye
        if (instance == null)          
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
  
    void Update()
    {
        if(Input.GetMouseButton(0) && isGameOver)
        {
            RestartGame();
        }
    }

    public void GameOver()
    {

        isGameOver = true;
        gameOverText.SetActive(true);
    
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    private void NextLevel()
    {

    }
}
