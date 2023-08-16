using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SujetoConcreto : ISujeto
{
    public bool tiempoActivo { get; set; }
    //El que va a producir la actualizacion
    public float tiempoAct { get; set; }//tiempo actual del temporizador

    public string mensaje { get; set; }

    public Color colorMensaje { get; set; }

    private readonly List<IObservador> _observador;

    public SujetoConcreto() { 
        _observador=new List<IObservador>();
        tiempoAct = 0;
        tiempoActivo=false;
        notifyObservers();
    }

    public void addObserver(IObservador observador)
    {
        _observador.Add(observador);
    }
    public void removeObserver(IObservador observador)
    {
        _observador.Remove(observador);
    }
    public void notifyObservers()
    {
        foreach (var observer in _observador)
        {
            observer.update(this);
        }
    }

    public void actualizaTemporizador(UnityEngine.UI.Slider slider, GameManager gameManager)
    {
        tiempoAct -= Time.deltaTime;

        if (tiempoAct >= 0)
        {
            slider.value = tiempoAct;
        }

        if (tiempoAct <= 0)
        {
            colorMensaje=Color.red;
            mensaje = "El Tiempo se Terminó";
            notifyObservers();
            actualizaEstadoTemp(false);
            gameManager.GameOver();
        }

        if (tiempoAct >= 20 && tiempoAct <=30)
        {
            colorMensaje = Color.yellow;
            mensaje = "Casi se agota el tiempo ¡Corre!";
            notifyObservers();
        }

    }


    public void actualizaEstadoTemp(bool status)
    {
        tiempoActivo = status;

    }

    public void activarTemp(float tiempoMax, UnityEngine.UI.Slider slider)
    {
        tiempoAct = tiempoMax;
        slider.maxValue = tiempoMax;
        actualizaEstadoTemp(true);
    }

    public void desactivarTemp()
    {
        actualizaEstadoTemp(false);
    }
}
