using Assets.Scripts.AbstractFactory;
using Heroes;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Patron SINGLETON:
    //Va manejar el mensaje de texto de game over, reiniciar el nivel, actualizar puntajes y todo
    //aquello relacionado con el seguimiento del juego en una sola instancia
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject jugador;
    public bool isGameOver;

    //Patron FABRICA ABSTRACTA:
    //El patron manejara la creación de los jefes de cada zona utilizando
    //una configuración que dentro de el estaran los prefabs de los jefes
    [SerializeField] private EnemigosConfiguration enemigosConfiguration;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene(); //Guarda en la variable la escena actual
        var factoryEnemigo = new EnemigoFactory(Instantiate(enemigosConfiguration)); //Instancia la configuración de enemigos
        string sceneName = currentScene.name; //Obtiene el nombre de la escena

        if (sceneName == "Zona1-Nivel1") //Si el nombre de la escena coincide con la indicada
        {
            factoryEnemigo.Create("JefeLaboratorio");//Crea el objeto desde la fabrica abstracta
        }
        else if (sceneName == "Zona2-nivel2")
        {
            factoryEnemigo.Create("JefeBosque");

        }
        else if (sceneName == "ZonaCuevaNivel1")
        {
            factoryEnemigo.Create("JefeCueva");
        }
    }

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

        jugador.GetComponent<Jugador>().DestruirJugador();
    }   

    private void RestartGame()
    {
        SceneManager.LoadScene("Maps");
    }


}
