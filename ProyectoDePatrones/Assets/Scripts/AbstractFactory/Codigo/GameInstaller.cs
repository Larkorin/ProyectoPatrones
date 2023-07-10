using Assets.Scripts.AbstractFactory;
using Heroes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstaller : MonoBehaviour
{
    [SerializeField] private EnemigosConfiguration enemigosConfiguration;

    //private Consumer consumer;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
       
        var factoryEnemigo = new EnemigoFactory(Instantiate(enemigosConfiguration));
        var consumerGameObject = new GameObject();

        //consumer = consumerGameObject.AddComponent<Consumer>();
        //consumer.Configure(factoryEnemigo);

        string sceneName = currentScene.name;

        if (sceneName == "Zona1-nivel3")
        {
            factoryEnemigo.Create("JefeLaboratorio");

        } else if (sceneName == "Zona2-nivel2")
        {
            factoryEnemigo.Create("JefeBosque");

        } else if (sceneName == "ZonaCuevaNivel1")
        {
            factoryEnemigo.Create("JefeCueva");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
