using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorObservador : MonoBehaviour
{

    [SerializeField] private float tiempoMax;
    //private float tiempoAct;
    //private bool tiempoActivo = false;
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

        //if (Input.GetKeyUp(KeyCode.Q)) {
        //    _sujetoConcreto.aplicarTiempo(10);
        //}

    }

    //private void actualizaTemporizador() {
    //    tiempoAct -= Time.deltaTime;

    //    if (tiempoAct>=0) { 
    //        slider.value = tiempoAct;
    //    }

    //    if (tiempoAct <= 0)
    //    {
    //        Debug.Log("Tiempo ha Terminado");
    //       actualizaEstadoTemp(false);
    //    }
    //}


    //private void actualizaEstadoTemp(bool status) { 
    //    tiempoActivo= status;
    
    //}

    //private void activarTemp() { 
    //    tiempoAct= tiempoMax;
    //    slider.maxValue= tiempoMax;
    //    _sujetoConcreto.actualizaEstadoTemp(true);
    //}

    //private void desactivarTemp()
    //{
    //    _sujetoConcreto.actualizaEstadoTemp(false);
    //}
}
