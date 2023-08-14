using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorObservador : MonoBehaviour
{

    [SerializeField] private float tiempoMax;
    private float tiempoAct;
    private bool tiempoActivo = false;
    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        activarTemp();
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoActivo) {
            actualizaTemporizador();
        }
    }

    private void actualizaTemporizador() {
        tiempoAct -= Time.deltaTime;

        if (tiempoAct>=0) { 
            slider.value = tiempoAct;
        }

        if (tiempoAct <= 0)
        {
            Debug.Log("Tiempo ha Terminado");
           actualizaEstadoTemp(false);
        }
    }


    private void actualizaEstadoTemp(bool status) { 
        tiempoActivo= status;
    
    }

    private void activarTemp() { 
        tiempoAct= tiempoMax;
        slider.maxValue= tiempoMax;
        actualizaEstadoTemp(true);
    }

    private void desactivarTemp()
    {
        actualizaEstadoTemp(false);
    }
}
