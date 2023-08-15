using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObservadorConcreto :MonoBehaviour, IObservador
{
    [SerializeField] private TextMeshProUGUI _textTiempo;
    public void update(ISujeto sujeto)
    {
        if (sujeto is SujetoConcreto sujectC) { //casting a la clase que estoy esperando
           
        _textTiempo.SetText(sujectC.mensaje);
        _textTiempo.color= sujectC.colorMensaje;
        }
    }

}
