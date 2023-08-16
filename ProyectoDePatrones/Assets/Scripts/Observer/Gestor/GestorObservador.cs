using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorObservador : MonoBehaviour
{

    [SerializeField] private float tiempoMax;
   
    [SerializeField] private Slider slider;
    [SerializeField] private GameManager _gameManager;


    [SerializeField] private ObservadorConcreto _observadorTime;
    private SujetoConcreto _sujetoConcreto; 
    
    private void Awake()
    {
        _sujetoConcreto=new SujetoConcreto();
        _sujetoConcreto.addObserver(_observadorTime);
    }

    void Start()
    {
        _sujetoConcreto.activarTemp(tiempoMax,slider);
    }

    // Update is called once per frame
    void Update()
    {
        if (_sujetoConcreto.tiempoActivo) {
            _sujetoConcreto.actualizaTemporizador(slider,_gameManager);
        }

        

    }

   
}
